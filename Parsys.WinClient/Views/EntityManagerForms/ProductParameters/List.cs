using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductParameters
{


    public partial class List : ViewBaseControl
    {
        private Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        private ProductParametersRepository repo;
        private ProductCategoriesRepository catRepo;
        private GridHandler<DataLayer.Entities.EntityModels.ProductParameters> grid;
        public IEnumerable<DataLayer.Entities.EntityModels.ProductParameters> GetFromRepo;
        public int CatId = 0; 

        public List()
        {
            InitializeComponent();
            repo = new ProductParametersRepository(con.GetConnection());
            catRepo = new ProductCategoriesRepository(con.GetConnection());

            
            Id = "ProductParametersList";
            MultipleInstance = true;


            if (CatId != 0)
            {
                GetFromRepo = repo.GetByIsDeleted(false).Where(c => c.Id == CatId);
                Title = "لیست پارامترهای " + catRepo.GetById(CatId).First().Title;
            }
            else
            {
                Title = "لیست پارامترها";
            }


            //if (GetFromRepo == null)
                //GetFromRepo = repo.GetByIsDeleted(false);


                AddButtun("جدید", b =>
                {
                    var newForm = ViewManagement.ShowForm<Editor>((nw) =>
                    {
                        if (CatId != 0)
                            nw.CatId = CatId;
                        nw.Entity = new DataLayer.Entities.EntityModels.ProductParameters();
                        nw.Title = "تعریف پارامتر جدید";
                    }, true);

                    if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                    {
                        repo.Insert(newForm.Entity);
                        grid.AddItem(newForm.Entity);
                    }


                });

            AddButtun("ویرایش", b =>
            {
                onDoubleClick();
            });

            AddButtun("حذف", b =>
            {
                if (grid.CurrentIndex == -1)
                {
                    MessageBox.Show("سطری انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("آیا از حذف \"" + grid.CurrentItem.Title + "\" اطمینان دارید", "پیام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grid.CurrentItem.IsDeleted = true;
                    grid.CurrentItem.DeleteDate = DateTime.Now;
                    repo.Update(grid.CurrentItem);
                    grid.RemoveItem(grid.CurrentIndex);
                }


            });
        }

        protected void onDoubleClick()
        {
            if (grid.CurrentIndex == -1)
            {
                MessageBox.Show("سطری انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var edtView = ViewManagement.ShowForm<Editor>(edt =>
            {
                edt.Entity = grid.CurrentItem;
                edt.Title = "ویرایش پارامتر";
            }, true);


            if (((Form)edtView.Parent).DialogResult == DialogResult.OK)
            {
                repo.Update(edtView.Entity);
                grid.UpdateItem(edtView.Entity, grid.CurrentIndex);
            }

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            grid = new GridHandler<DataLayer.Entities.EntityModels.ProductParameters>(this, GetFromRepo);
            grid.OnDoubleClick += (s, a) => { onDoubleClick(); };

            grid.AddStringColumn(i => i.ProductCategoryId, "دسته بندی");
            grid.AddStringColumn(i => i.Title, "عنوان");
            grid.AddStringColumn(i => i.Key, "کید");
            grid.AddStringColumn(i => i.Description, "توضیحات");



        }
    }
}

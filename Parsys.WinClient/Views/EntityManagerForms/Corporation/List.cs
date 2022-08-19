using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;
using Parsys.DataLayer.Entities.EntityModels;

namespace Parsys.WinClient.Views.EntityManagerForms.Corporation
{


    public partial class List : ViewBaseControl
    {
        private Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        private CorporationsRepository repo;
        private GridHandler<Corporations> grid;

        public List()
        {
            InitializeComponent();
            repo = new CorporationsRepository(con.GetConnection());
            grid = new GridHandler<Corporations>(this, repo.GetByIsDeleted(false));

            Title = "لیست شرکت ها";
            Id = "CorporationsList";
            MultipleInstance = false;

            AddButtun("جدید", b =>
            {
                var newForm =ViewManagement.ShowForm<Editor>((nw) =>
                {
                    nw.Entity = new Corporations();
                    nw.Title = "تعریف شرکت جدید";
                },true);

                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Insert(newForm.Entity);
                    //grid.RefreshDataSource(repo.GetByIsDeleted(false));
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
                    MessageBox.Show("سطری انتخاب نشده است","پیام سیستم",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if(MessageBox.Show("آیا از حذف \"" + grid.CurrentItem.Title + "\" اطمینان دارید" , "پیام سیستم",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grid.CurrentItem.IsDeleted = true;
                    repo.Update(grid.CurrentItem);
                    //grid.RefreshDataSource(repo.GetByIsDeleted(false));
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
                edt.Title = "ویرایش شرکت";
            }, true);


            if (((Form)edtView.Parent).DialogResult == DialogResult.OK)
            {
                repo.Update(edtView.Entity);
                grid.UpdateItem(edtView.Entity,grid.CurrentIndex);
            }

            //grid.RefreshDataSource(repo.GetByIsDeleted(false));
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            grid.OnDoubleClick += (s, a) => { onDoubleClick(); };


            grid.AddStringColumn(i => i.Title, "عنوان");
            grid.AddStringColumn(i => i.Telephone, "تلفن");
            grid.AddStringColumn(i => i.Fax, "فکس");
            grid.AddStringColumn(i => i.Address, "آدرس");
            grid.AddStringColumn(i => i.Description, "توضیحات");



        }
    }
}

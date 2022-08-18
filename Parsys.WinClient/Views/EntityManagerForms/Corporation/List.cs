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
            Id = "ListOfCorporations";
            MultipleInstance = false;

            AddButtun("جدید", b =>
            {
                //ViewManagement.ShowForm<>();
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
                    repo.Delete(grid.CurrentItem);
                }


            });
        }

        protected void onDoubleClick()
        {


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

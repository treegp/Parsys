using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.InventoryForms
{


    public partial class List : ViewBaseControl
    {
        private DataLayer.Connections.ProviderMethods.ConnectToSQL con = new DataLayer.Connections.ProviderMethods.ConnectToSQL();
        public InventoriesRepository invRepo;
        GridHandler<Inventories> grid;


        public List()
        {


            InitializeComponent();
            Id = "ListInventories";
            Title = "لیست انبار ها";
            MultipleInstance = false;

            AddButtun("جدید", b =>
            {
                ViewManagement.ShowForm<Editor>(null,true);
            });

            AddButtun("حذف", b =>
            {
                if (grid.CurrentItem == null)
                {
                    MessageBox.Show("سطری انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("آیا مایل به حذف " + grid.CurrentItem.Title + " هستید؟", "حذف انبار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    invRepo.Delete(grid.CurrentItem);
                    grid.RemoveItem(grid.CurrentItem);
                }
            });

        }


        protected override void OnLoad(EventArgs e)
        {
            invRepo = new InventoriesRepository(con.GetConnection());

            grid = new GridHandler<DataLayer.Entities.EntityModels.Inventories>(this, invRepo.GetAll());

            grid.AddStringColumn(i => i.Id, "شناسه انبار");
            grid.AddStringColumn(i => i.CorporationId, "شناسه شرکت");
            grid.AddStringColumn(i => i.Title, "عنوان");
            grid.AddStringColumn(i => i.Description, "توضیحات");
            grid.AddStringColumn(i => i.IsDeleted, "غیر فعال");



            base.OnLoad(e);
        }
    }
}

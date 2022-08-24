using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Linq;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductCategories
{
    public partial class Editor : EntityEditorClass<DataLayer.Entities.EntityModels.ProductCategories>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public ProductCategoriesRepository Repo;
        public InventoriesRepository invRepo;

        //public DataLayer.Entities.EntityModels.ProductCategories returnEntity;


        public Editor()
        {

            InitializeComponent();

            Repo = new ProductCategoriesRepository(con.GetConnection());
            invRepo = new InventoriesRepository(con.GetConnection());


            Title = "";
            Id = "ProductCategoriesEditor";
            MultipleInstance = false;







        }


        protected override void OnLoad(EventArgs e)
        {
            if (Entity.ParentCategoryId == null)
            {
                NewComboBox(i => i.InventoryId, "عنوان انبار", invRepo.GetByIsDeleted(false), c => c.Title, c => c.Id);
            }
            else
            {
                var textbox = NewTextBox("دسته بندی والد");
                textbox.Enabled = false;
                textbox.Text = Repo.GetById((int)Entity.ParentCategoryId).FirstOrDefault().Title;
            }
            NewTextBox(i => i.Title, "عنوان");
            NewTextBox(i => i.Description, "توضیحات", true);
            ArrangementControls();
            base.OnLoad(e);
        }
    }
}

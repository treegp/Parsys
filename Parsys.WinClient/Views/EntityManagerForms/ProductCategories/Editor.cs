using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductCategories
{
    public partial class Editor : EntityEditorClass<DataLayer.Entities.EntityModels.ProductCategories>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public ProductCategoriesRepository Repo;
        public InventoriesRepository invRepo;


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
            base.OnLoad(e);

            NewComboBox(i => i.InventoryId, "عنوان انبار", invRepo.GetByIsDeleted(false), c => c.Title, c => c.Id);
            NewTextBox(i => i.Title, "عنوان");
            NewComboBox(i => i.ParentCategoryId, "عنوان دسته بندی والد", Repo.GetByIsDeleted(false), c => c.Title, c => c.Id);
            NewTextBox(i => i.Description, "توضیحات", true);
            ArrangementControls();

        }
    }
}

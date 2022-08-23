using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Linq;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductCategories
{


    public partial class List : ViewBaseControl
    {
        private Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        private ProductCategoriesRepository repo;
        private InventoriesRepository invRepo;
        private GridHandler<DataLayer.Entities.EntityModels.ProductCategories> grid;

        public List()
        {
            InitializeComponent();
            repo = new ProductCategoriesRepository(con.GetConnection());
            invRepo = new InventoriesRepository(con.GetConnection());

            Title = "لیست دسته بندی ها";
            Id = "ProductCategoriesList";
            MultipleInstance = false;

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TreeControl treeControl = new TreeControl(this);
            treeControl.OnExpand += (parentNode, parentObject) =>
            {
                int id = ((DataLayer.Entities.EntityModels.ProductCategories)parentObject).Id;
                var rootNodes = repo.GetByParentCategoryId(id);
                return rootNodes.Select(c => new ClassNode() { Text = c.Title, Tag = c });
            };

        }
    }



}

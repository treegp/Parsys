using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                List<TreeItem> roots = new List<TreeItem>();
                if (parentNode == null)
                {


                    for (int i = 1; i <10; i++)
                    {
                        Items p = new Items() { Id= 20 + i, Name = "Item " + i };

                        roots.Add(new TreeItem()
                        {
                            Text = p.Name,
                            Object = p
                        });
                    }

                }

                return roots;
            };

            treeControl.InitializeTree();

        }
    }


    public class Items
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Linq;
using System.Windows.Forms;
using EntityModels = Parsys.DataLayer.Entities.EntityModels;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductCategories
{


    public partial class List : ViewBaseControl
    {
        private Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        private ProductCategoriesRepository repo;
        private InventoriesRepository invRepo;

        public TreeControl<EntityModels.ProductCategories> treeControl;

        public List()
        {
            InitializeComponent();
            repo = new ProductCategoriesRepository(con.GetConnection());
            invRepo = new InventoriesRepository(con.GetConnection());
            treeControl = new TreeControl<EntityModels.ProductCategories>(this);


            Title = "لیست دسته بندی ها";
            Id = "ProductCategoriesList";
            MultipleInstance = false;

            AddButtun("ریشه جدید", btn =>
            {

                var newForm = ViewManagement.ShowForm<Editor>((s) =>
                {
                    s.Entity = new DataLayer.Entities.EntityModels.ProductCategories();
                    s.Entity.IsDeleted = false;
                    s.Entity.ParentCategoryId = null;

                }, true);

                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Insert(newForm.Entity);
                    treeControl.InitializeTree();
                }

            });

            AddButtun("زیرمجموعه جدید", btn =>
            {
                treeControl.GetExpansion();
                if (treeControl.CurrentNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var currentPath = treeControl.PathNode;
                var newForm = ViewManagement.ShowForm<Editor>((s) =>
                    {
                        s.Entity = new DataLayer.Entities.EntityModels.ProductCategories();
                        s.Entity.IsDeleted = false;
                        s.Entity.ParentCategoryId = treeControl.CurrentNode.Id;
                        s.Entity.InventoryId = treeControl.CurrentNode.InventoryId;

                    }, true);


                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Insert(newForm.Entity);
                    treeControl.InitializeTree();
                    treeControl.GotoNode(currentPath);
                }

            });

            AddButtun("ویرایش دسته بندی", btn =>
            {
                if (treeControl.CurrentNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var currentPath = treeControl.PathNode;
                var newForm = ViewManagement.ShowForm<Editor>((s) =>
                    {
                        s.Entity = treeControl.CurrentNode;
                    }, true);


                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Update(newForm.Entity);
                    treeControl.InitializeTree();
                    
                    //treeControl.GotoNode(currentPath);
                }

            });

            AddButtun("حذف دسته بندی", btn =>
            {
                if (treeControl.CurrentNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var item = treeControl.CurrentNode;

                if (MessageBox.Show("آیا از حذف \"" + item.Title + "\" اطمینان دارید", "پیام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    item.IsDeleted = true;
                    repo.Update(item);
                    treeControl.InitializeTree();
  
                }
            });


        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            treeControl.OnExpand += (parentNode, parentObject) =>
            {

                if (parentObject == null)
                {
                    var rootNodes = repo.GetByParentCategoryId(null).Where(c => c.IsDeleted == false);
                    return rootNodes.Select(c => new ClassNode<EntityModels.ProductCategories>() { Text = c.Title, Tag = c });
                }
                else
                {

                    var rootNodes = repo.GetByParentCategoryId(((DataLayer.Entities.EntityModels.ProductCategories)parentObject).Id).Where(c=>c.IsDeleted==false);
                    return rootNodes.Select(c => new ClassNode<EntityModels.ProductCategories>() { Text = c.Title, Tag = c });
                }
            };


            treeControl.InitializeTree();

        }
    }



}

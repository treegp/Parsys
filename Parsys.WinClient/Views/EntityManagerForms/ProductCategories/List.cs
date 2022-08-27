using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntityModels = Parsys.DataLayer.Entities.EntityModels;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductCategories
{


    public partial class List : ViewBaseControl
    {
        private ConnectToSQL con = new ConnectToSQL();
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
                treeControl.ExpandedNodeList = new List<NodeExpand>();
                var expandedNodes = treeControl.GetTreeState(treeControl.treeView.Nodes);
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
                treeControl.SetTreeState(treeControl.treeView.Nodes, expandedNodes);

            });

            AddButtun("زیرمجموعه جدید", btn =>
            {
                


                if (treeControl.CurrentTagNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                treeControl.ExpandedNodeList = new List<NodeExpand>();
                var expandedNodes = treeControl.GetTreeState(treeControl.treeView.Nodes);
                var currentPath = treeControl.PathNode;
                var newForm = ViewManagement.ShowForm<Editor>((s) =>
                    {
                        s.Entity = new DataLayer.Entities.EntityModels.ProductCategories();
                        s.Entity.IsDeleted = false;
                        s.Entity.ParentCategoryId = treeControl.CurrentTagNode.Id;
                        s.Entity.InventoryId = treeControl.CurrentTagNode.InventoryId;

                    }, true);


                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Insert(newForm.Entity);
                    treeControl.InitializeTree();

                }

                treeControl.SetTreeState(treeControl.treeView.Nodes, expandedNodes);

            });

            AddButtun("ویرایش دسته بندی", btn =>
            {
                if (treeControl.CurrentTagNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                treeControl.ExpandedNodeList = new List<NodeExpand>();
                var expandedNodes = treeControl.GetTreeState(treeControl.treeView.Nodes);
                var currentPath = treeControl.PathNode;
                var newForm = ViewManagement.ShowForm<Editor>((s) =>
                    {
                        s.Entity = treeControl.CurrentTagNode;
                    }, true);


                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Update(newForm.Entity);
                    treeControl.InitializeTree();

                }
                treeControl.SetTreeState(treeControl.treeView.Nodes, expandedNodes);

            });

            AddButtun("حذف دسته بندی", btn =>
            {
                if (treeControl.CurrentTagNode == null)
                {
                    MessageBox.Show("دسته بندی انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                treeControl.ExpandedNodeList = new List<NodeExpand>();
                var expandedNodes = treeControl.GetTreeState(treeControl.treeView.Nodes);
                var item = treeControl.CurrentTagNode;

                if (MessageBox.Show("آیا از حذف \"" + item.Title + "\" اطمینان دارید", "پیام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    item.IsDeleted = true;
                    repo.Update(item);
                    treeControl.InitializeTree();
  
                }
                treeControl.SetTreeState(treeControl.treeView.Nodes, expandedNodes);
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

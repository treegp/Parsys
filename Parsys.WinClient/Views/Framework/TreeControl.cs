using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl : UserControl
    {
        private TreeView treeView;
        public event Func<TreeNode, object, IEnumerable<TreeItem>> OnExpand;

        public TreeControl(Control container)
        {
            InitializeComponent();
            treeView = new TreeView();
            container.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.RightToLeftLayout = true;

        }

        public void InitializeTree()
        {
            var nodes = CreateChildNodes(ExpandNode(null, null));
            foreach (var node in nodes)
            {
                treeView.Nodes.Add(node);
            }

        }


        public IEnumerable<ClassNode> ExpandNode<TModel>(TreeNode parentNode,object objectNode,TModel model)
        {
            if (parentNode == null)
            { 


            }
            else
            {

            }




        }




        private List<TreeNode> CreateChildNodes (IEnumerable<ClassNode> items)
        {
            List<TreeNode> childList = new List<TreeNode>();
            foreach (var item in items)
            {
                var child = new TreeNode() { Text = item.Text, Tag = item };
                childList.Add(child);
            }
            return childList;
        }
    }

    public class ClassNode
    {
        public string Text { get; set; }
        public object Tag { get; set; }
    }
}

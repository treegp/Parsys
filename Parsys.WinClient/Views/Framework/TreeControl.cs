using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl : UserControl
    {
        private TreeView treeView;
        public event Func<TreeNode, object, IEnumerable<TreeItem>> OnExpandTree;

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
            var nodes = CreateTree(OnExpandTree(null, null));
            foreach (var node in nodes)
            {
                treeView.Nodes.Add(node);
            }

        }

        private List<TreeNode> CreateTree(IEnumerable<TreeItem> items)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (var item in items)
            {
                var newNode = new TreeNode() { Text = item.Text, Tag = item };
                nodes.Add(newNode);
            }

            return nodes;
        }
    }

    public class TreeItem
    {
        public string Text { get; set; }
        public object Object { get; set; }
    }
}

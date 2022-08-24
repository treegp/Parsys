using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Linq;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl : UserControl
    {
        private TreeView treeView;
        public event Func<TreeNode, object, IEnumerable<ClassNode>> OnExpand;
        public TreeNode CurrentNode { get => treeView.SelectedNode; }

        public TreeControl(Control container)
        {
            InitializeComponent();
            treeView = new TreeView();
            container.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.RightToLeftLayout = true;
            treeView.BeforeExpand += (o, e) =>
            {
                if (e.Node.Nodes.Count==1 & e.Node.Nodes[0].Tag is string & e.Node.Nodes[0].Tag == "not expanded" )
                {
                    e.Node.Nodes.Clear();
                    var nodes = ChildNodes(OnExpand(e.Node, e.Node.Tag));
                    foreach (var node in nodes)
                    {
                        e.Node.Nodes.Add(node);
                    }
                }
            };

        }

        public void InitializeTree()
        {
            treeView.Nodes.Clear();
            var nodes = ChildNodes(OnExpand(null, null));
            foreach (var node in nodes)
            {
                treeView.Nodes.Add(node);
            }
        }

       
   
        private List<TreeNode> ChildNodes (IEnumerable<ClassNode> items)
        {
            List<TreeNode> childList = new List<TreeNode>();
            foreach (var item in items)
            {
                var child = new TreeNode() { Text = item.Text, Tag = item.Tag };
                child.Nodes.Add(new TreeNode() { Text = "", Tag = "not expanded" });
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl<TType> : UserControl
    {
        public TreeView treeView;
        public event Func<TreeNode, TType, IEnumerable<ClassNode<TType>>> OnExpand;
        public TType CurrentTagNode { get { return treeView.SelectedNode == null ? default(TType) : (TType)treeView.SelectedNode.Tag; } }
        public TreeNode SelectedNode { get { return treeView.SelectedNode; } }
        public List<TreeNode> PathNode;
        public List<NodeExpand> ExpandedNodeList;

        public TreeControl(Control container)
        {
            InitializeComponent();
            treeView = new TreeView();
            var textbox = new TextBox();
            container.Controls.Add(textbox);
            textbox.Dock = DockStyle.Bottom;
            textbox.Enabled = false;
            container.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.RightToLeftLayout = true;
            treeView.BeforeExpand += (o, e) =>
            {
                if (e.Node.Nodes.Count == 1 & e.Node.Nodes[0].Tag is string & e.Node.Nodes[0].Tag.ToString() == "not expanded")
                {
                    e.Node.Nodes.Clear();
                    var nodes = ChildNodes(OnExpand(e.Node, (TType)e.Node.Tag));
                    foreach (var node in nodes)
                    {
                        e.Node.Nodes.Add(node);
                    }
                }
            };

            treeView.AfterSelect += (o, e) =>
            {
                PathNode = new List<TreeNode>();
                TreeNode node = e.Node;
                treeView.PathSeparator = " › ";
                textbox.Text = node.FullPath;

                while (node != null)
                {
                    PathNode.Add(node);
                    node = node.Parent;
                }

                PathNode.Reverse();
            };

        }


        public List<NodeExpand> GetTreeState(TreeNodeCollection Nodes)
        {

            foreach (TreeNode checknode in Nodes)
            {

                ExpandedNodeList.Add(new NodeExpand()
                {
                    Index = checknode.Index,


                    ParentIndex = checknode.Parent != null ? checknode.Parent.Index :  null,
                    IsExpanded = checknode.IsExpanded,
                    Level = checknode.Level
                });
                if (checknode.Nodes.Count > 0)
                    if (checknode.Nodes[0].Tag.ToString() != "not expanded")
                        GetTreeState(checknode.Nodes);
            }
            return ExpandedNodeList;
        }


        public void SetTreeState(List<NodeExpand> state)
        {
            int maxLevel = state.Max(n => n.Level);
            for (int i = 0; i < maxLevel; i++)
            {
                foreach (var node in state.Where(n => n.Level == i & n.IsExpanded == true))
                {
                    node.Node.Expand();
                }
            }
        }






        public void InitializeTree()
        {
            treeView.Nodes.Clear();
            var nodes = ChildNodes(OnExpand(null, default(TType)));
            foreach (var node in nodes)
            {
                treeView.Nodes.Add(node);
            }
        }



        private List<TreeNode> ChildNodes(IEnumerable<ClassNode<TType>> items)
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

    public class ClassNode<TType>
    {
        public string Text { get; set; }
        public TType Tag { get; set; }
    }

    public class NodeExpand
    {
        public int Index { get; set; }
        public int? ParentIndex { get; set; }
        public bool IsExpanded { get; set; }
        public int Level { get; set; }
    }

}

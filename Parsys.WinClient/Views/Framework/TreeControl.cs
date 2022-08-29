using System;
using System.Collections.Generic;
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

        public List<TraceNode> TraceNodeList;


        public TreeControl(Control container)
        {
            InitializeComponent();
            treeView = new TreeView();
            var textbox = new TextBox();
            container.Controls.Add(textbox);
            textbox.Dock = DockStyle.Top;
            textbox.Enabled = false;
            container.Controls.Add(treeView);
            treeView.Scrollable = true;
            treeView.Dock = DockStyle.Fill;
            treeView.BringToFront();
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




        public List<TraceNode> GetState(TreeNode node)
        {
            TraceNode traceNode = new TraceNode();
            traceNode.IsExpanded = node.IsExpanded;
            traceNode.Text = node.Text;

            TreeNode tempNode = node;
            for (int i = node.Level; i >= 0; i--)
            {
                traceNode.IndexList.Add(tempNode.Index);
                if (i != 0) tempNode = tempNode.Parent;
            }
            traceNode.IndexList.Reverse();
            return new List<TraceNode> { traceNode };
        }




        public List<TraceNode> GetState(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                TraceNode traceNode = new TraceNode();
                traceNode.IsExpanded = node.IsExpanded;
                traceNode.Text = node.Text;

                TreeNode tempNode = node;
                for (int i = node.Level; i >= 0; i--)
                {
                    traceNode.IndexList.Add(tempNode.Index);
                    if (i != 0) tempNode = tempNode.Parent;
                }

                traceNode.IndexList.Reverse();
                TraceNodeList.Add(traceNode);

                if (node.Nodes.Count > 0)
                    if (node.Nodes[0].Tag.ToString() != "not expanded")
                        GetState(node.Nodes);
            }
            return TraceNodeList;
        }



        public void SetState(TraceNode node, bool? expanding, bool selecting = false)
        {
            TreeNodeCollection tempNodes = treeView.Nodes;
            if (node.IndexList.Count > 1)
            {
                for (int i = 0; i < node.IndexList.Count - 1; i++)
                {
                    tempNodes[node.IndexList[i]].Expand();
                    tempNodes = tempNodes[node.IndexList[i]].Nodes;
                }
                
            }

            if (expanding == true & tempNodes[node.IndexList[node.IndexList.Count - 1]].Nodes.Count > 0)
                tempNodes[node.IndexList[node.IndexList.Count - 1]].Expand();
            else if (expanding == false & tempNodes[node.IndexList[node.IndexList.Count - 1]].Nodes.Count>0)
                tempNodes[node.IndexList[node.IndexList.Count - 1]].Collapse();
            else if (node.IsExpanded & tempNodes[node.IndexList[node.IndexList.Count - 1]].Nodes.Count > 0)
                tempNodes[node.IndexList[node.IndexList.Count - 1]].Expand();

            if (selecting)
                treeView.SelectedNode = tempNodes[node.IndexList[node.IndexList.Count - 1]];

        }


        public void SetState(List<TraceNode> traceNode)
        {

            foreach (TraceNode node in traceNode)
            {
                if (node.IsExpanded)
                {
                    TreeNodeCollection tempNodes = treeView.Nodes;
                    for (int i = 0; i < node.IndexList.Count; i++)
                    {
                        try
                        {
                            tempNodes[node.IndexList[i]].Expand();
                            tempNodes = tempNodes[node.IndexList[i]].Nodes;
                        }
                        catch { }
                    }
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

    public class TraceNode
    {
        public List<int> IndexList { get; set; } = new List<int>();
        public string Text { get; set; }
        public bool IsExpanded { get; set; }
    }

}

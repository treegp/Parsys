﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl<TType> : UserControl
    {
        private TreeView treeView;
        public event Func<TreeNode, TType, IEnumerable<ClassNode<TType>>> OnExpand;
        public TType CurrentNode { get { return treeView.SelectedNode == null ? default(TType) : (TType)treeView.SelectedNode.Tag; } }
        public List<TreeNode> PathNode;

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

        public TreeNode SelectedNode
        {
            get { return treeView.SelectedNode; }
        }



        public void GotoNode(List<TreeNode> pathNode)
        {
            foreach (var node in pathNode)
            {
                node.Expand();
            }



        }






        public List<NodeExpansion> expansion = new List<NodeExpansion>();

        public void GetExpansion(TreeNodeCollection parentList)
        {
            foreach (TreeNode node in parentList.OfType<TreeNode>())
            {
                expansion.Add(new NodeExpansion()
                {
                    Node = node,
                    NodeExpanded = node.IsExpanded,
                    NodeLevel = node.Level
                });
                GetExpansion(node.Nodes);
            }
        }




        public TreeNodeCollection GetRoots()
        {
            return treeView.Nodes;
        }


        public List<NodeExpansion> GetRootss()
        {
            List<NodeExpansion> expansion = new List<NodeExpansion>();

            foreach (TreeNode node in treeView.Nodes)
            {
                expansion.Add(new NodeExpansion()
                {
                    Node = node,
                    NodeExpanded = node.IsExpanded,
                    NodeLevel = node.Level
                });
            }

            return expansion;
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

    public class NodeExpansion
    {
        public int NodeLevel { get; set; }
        public TreeNode Node { get; set; }
        public bool NodeExpanded { get; set; }
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Linq;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TreeControl<TType> : UserControl
    {
        private TreeView treeView;
        public event Func<TreeNode, TType, IEnumerable<ClassNode<TType>>> OnExpand;
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
                if (e.Node.Nodes.Count==1 & e.Node.Nodes[0].Tag is string & e.Node.Nodes[0].Tag.ToString() == "not expanded" )
                {
                    e.Node.Nodes.Clear();
                    var nodes = ChildNodes(OnExpand(e.Node, (TType)e.Node.Tag));
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
            var nodes = ChildNodes(OnExpand(null, default(TType)));
            foreach (var node in nodes)
            {
                treeView.Nodes.Add(node);
            }
        }

       
   
        private List<TreeNode> ChildNodes (IEnumerable<ClassNode<TType>> items)
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
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{

    public class MenuStripHandler
    {
        private ToolStripItemCollection itemsHierarchy;

        public MenuStripHandler(ToolStripItemCollection collection)
        {
            itemsHierarchy = collection;
        }

        public MenuStripHandler AddMenuItem(string caption)
        {
            return AddMenuItem(caption, null, null);
        }

        public MenuStripHandler AddMenuItem(string caption, EventHandler e)
        {
            return AddMenuItem(caption, null, e);
        }


        public MenuStripHandler AddMenuItem(string caption, Image thumbnail, EventHandler e)
        {
            if (caption == "-")
            {
                AddMenuSeperator();
                return null;
            }

            var menu = (ToolStripMenuItem)itemsHierarchy.Add(caption, thumbnail, e);
            return new MenuStripHandler(menu.DropDownItems);
        }

        public void AddMenuSeperator()
        {
            var menu = itemsHierarchy.Add("-");
        }
    }


    public class TabControlHandler
    {
        private TabControl tabControler;
        private string TabID;
        private Dictionary<string, TabPage> openTabList = new Dictionary<string, TabPage>();

        public TabControlHandler(TabControl tabControl)
        {
            tabControler = tabControl;

            foreach (TabPage tab in tabControler.TabPages)
            {
                openTabList.Add(tab.Text, tab);
            }


        }


        public void AddTab(string caption)
        {
            var Tab = openTabList.Where(k => k.Key == caption).FirstOrDefault().Value;
            if (Tab == null)
            {
                tabControler.TabPages.Add(caption);
                openTabList.Add(caption, tabControler.TabPages[tabControler.TabPages.Count - 1]);
                tabControler.SelectedTab = tabControler.TabPages[tabControler.TabPages.Count - 1];
            }
            else
            {
                tabControler.SelectedTab = Tab;
            }
        }

    }






}

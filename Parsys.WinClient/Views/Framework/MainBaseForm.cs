using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        private MenuStripHandler menuManager;
        public MainBaseForm()
        {
            InitializeComponent();
            menuManager = new MenuStripHandler(MainMenuStrip.Items);
        }


        public MenuStripHandler AddMenu(string caption)
        {
            return menuManager.AddMenuItem(caption);
        }

        public MenuStripHandler AddMenu(string caption,  EventHandler e)
        {
            return menuManager.AddMenuItem(caption, e);
        }

        public MenuStripHandler AddMenu(string caption, Image thumbnail, EventHandler e)
        {
            return menuManager.AddMenuItem(caption, thumbnail, e);
        }


    }




    public class MenuStripHandler
    {
        private ToolStripItemCollection itemsHierarchy;

        public MenuStripHandler(ToolStripItemCollection collection)
        {
            itemsHierarchy = collection;
        }

        public MenuStripHandler AddMenuItem(string caption)
        {
            var menu = (ToolStripMenuItem)itemsHierarchy.Add(caption, null, null);
            return new MenuStripHandler(menu.DropDownItems);
        }

        public MenuStripHandler AddMenuItem(string caption, EventHandler e)
        {
            var menu = (ToolStripMenuItem)itemsHierarchy.Add(caption, null, e);
            return new MenuStripHandler(menu.DropDownItems);
        }


        public MenuStripHandler AddMenuItem(string caption, Image thumbnail, EventHandler e)
        {
            var menu = (ToolStripMenuItem)itemsHierarchy.Add(caption, thumbnail, e);
            return new MenuStripHandler(menu.DropDownItems);
        }
    }

}


using System;
using System.Drawing;
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

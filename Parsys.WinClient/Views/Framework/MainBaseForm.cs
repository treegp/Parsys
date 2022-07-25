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





}


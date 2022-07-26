using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        private MenuStripHandler menuManager;
        private TabControlHandler tabManager;


        public MainBaseForm()
        {
            InitializeComponent();
            menuManager = new MenuStripHandler(MainMenuStrip.Items);
            tabManager = new TabControlHandler(MainTabControl);


            var dt = MainStatusStrip.Items.Add(DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss"));

            DateTimeTimer.Enabled = true;
            DateTimeTimer.Tick += (obj, e) =>
            {
                dt.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss");
            };

            
        }


        public void AddTab(string caption)
        {
            tabManager.AddTab(caption);
        }




        public MenuStripHandler AddMenu(string caption)
        {
            return menuManager.AddMenuItem(caption, null, null);
        }

        public MenuStripHandler AddMenu(string caption, EventHandler e)
        {
            return menuManager.AddMenuItem(caption, null, e);
        }

        public MenuStripHandler AddMenu(string caption, Image thumbnail, EventHandler e)
        {
            return menuManager.AddMenuItem(caption, thumbnail, e);
        }

        public void AddSeperator()
        {
            menuManager.AddMenuSeperator();
        }


    }





}


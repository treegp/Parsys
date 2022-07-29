using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        private MenuStripHandler menuManager;
        private ViewHandler viewManager; 
        private TabControlHandler tabManager;


        public MainBaseForm()
        {
            InitializeComponent();
            menuManager = new MenuStripHandler(MainMenuStrip.Items);
            viewManager = new ViewHandler(MainTabControl);
            tabManager = new TabControlHandler(MainTabControl);


            var dt = MainStatusStrip.Items.Add(DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss"));

            DateTimeTimer.Enabled = true;
            DateTimeTimer.Tick += (obj, e) =>
            {
                dt.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss");
            };

            
        }


        //-----------------------------------------------------------------------
        public ViewHandler MainViewHandler()
        {
            return viewManager;
        }









        //-----------------------------------------------------------------------

        public void AddTab(string caption)
        {
            tabManager.AddTab(caption);
        }















        //-----------------------------------------------------------------------
        public MenuStripHandler MainMenuStripHandler()
        {
            return menuManager;
        }



        //-----------------------------------------------------------------------
        private void CloseCurrentTabButton_Click(object sender, EventArgs e)
        {

            viewManager.CloseTab(MainTabControl.SelectedTab);

            //tabManager.RemoveTab(MainTabControl.SelectedTab.Text);
        }
    }





}


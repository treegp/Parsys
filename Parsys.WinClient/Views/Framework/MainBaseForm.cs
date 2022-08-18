using System;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        private MenuStripHandler menuManager;
        private ViewHandler viewManager;



        public MainBaseForm()
        {
            InitializeComponent();
            menuManager = new MenuStripHandler(MainMenuStrip.Items);
            viewManager = new ViewHandler(MainTabControl);
            


            var dt = MainStatusStrip.Items.Add(DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss"));

            DateTimeTimer.Enabled = true;
            DateTimeTimer.Tick += (obj, e) =>
            {
                dt.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss");
            };


        }

        private void DatePicker_OnChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        //-----------------------------------------------------------------------
        public ViewHandler MainViewHandler()
        {
            return viewManager;
        }


        //-----------------------------------------------------------------------
        public MenuStripHandler MainMenuStripHandler()
        {
            return menuManager;
        }


        //-----------------------------------------------------------------------
        private void CloseCurrentTabButton_Click(object sender, EventArgs e)
        {

            viewManager.CloseView(MainTabControl.SelectedTab.Controls.OfType<ViewBaseControl>().FirstOrDefault());

            //tabManager.RemoveTab(MainTabControl.SelectedTab.Text);
        }
    }





}


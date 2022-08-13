using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

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

            var p = new System.Globalization.PersianCalendar();
            MainTabPage.Controls.Add(new DatePickerControl(new DateTime(1354,4,11, p)));


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


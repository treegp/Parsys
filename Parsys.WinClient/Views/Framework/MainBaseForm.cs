using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        public MainBaseForm()
        {
            InitializeComponent();

            var operationMenu = MainMenuStrip.Items.Add("عملیات");
            ((ToolStripMenuItem)operationMenu).DropDownItems.Add("خروج", null, (obj, e) =>
            {
                if (MessageBox.Show("آیا مایل به خروج از برنامه هستید؟", "پیام سیستم", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
            });


        }

     
    }
}

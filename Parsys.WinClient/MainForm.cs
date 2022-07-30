using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.WinClient.Views.CorporationForms;

namespace Parsys.WinClient
{
    public partial class MainForm : MainBaseForm
    {
        public MainForm()
        {
            InitializeComponent();


            var opMenu = MainMenuStripHandler().AddMenuItem("عملیات");
            opMenu.AddMenuItem("ورود");
            opMenu.AddMenuSeperator();
            opMenu.AddMenuItem("شرکت ها", (o, b) =>
            {
                MainViewHandler().OpenTab<List>();
            });


            opMenu.AddMenuItem("خروج", (o, e) =>
            {
                if (MessageBox.Show("آیا مایل به خروج از برنامه هستید؟", "پیام سیستم", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            });



            


        }
    }
}

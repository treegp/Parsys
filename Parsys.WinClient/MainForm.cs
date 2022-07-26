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

namespace Parsys.WinClient
{
    public partial class MainForm : MainBaseForm
    {
        public MainForm()
        {
            InitializeComponent();

            var opMenu = AddMenu("عملیات");
            opMenu.AddMenuItem("ورود", (o, e) =>
            {
                AddTab("ورود");
            });
            opMenu.AddMenuSeperator();
            opMenu.AddMenuItem("خروج", (o, e) =>
            {
            if (MessageBox.Show("آیا مایل به خروج از برنامه هستید؟","پیام سیستم", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    Close();
                }
            });


        }
    }
}

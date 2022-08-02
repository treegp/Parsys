﻿using Parsys.WinClient.Views.Framework;
using System.Windows.Forms;
using Parsys.WinClient.IoC;
using Parsys.WinClient.Views.CorporationForms;

namespace Parsys.WinClient
{
    public partial class MainForm : MainBaseForm
    {

        

        public MainForm() : base(new IoC.TypesRegistery())
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

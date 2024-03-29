﻿using Parsys.WinClient.Views.Framework;
using System.Windows.Forms;
using Parsys.WinClient.IoC;

namespace Parsys.WinClient
{
    public partial class MainForm : MainBaseForm
    {
        
        

        public MainForm()
        {
            InitializeComponent();
            var baseMenu = MainMenuStripHandler().AddMenuItem("اطلاعات پایه");
            baseMenu.AddMenuItem("مدیریت شرکت ها", (o,e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.Corporations.List>();
            });
            baseMenu.AddMenuItem("مدیریت سال های مالی", (o, e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.FinancialYears.List>();
            });
            baseMenu.AddMenuItem("مدیریت انبارها", (o, e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.Inventories.List>();
            });
            baseMenu.AddMenuItem("مدیریت واحد های اندازه گری", (o, e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.ProductUnits.List>();
            });
            


            var productMenu = MainMenuStripHandler().AddMenuItem("اطلاعات محصولات");
            productMenu.AddMenuItem("مدیریت محصولات", (o, e) =>
            {

            });
            productMenu.AddMenuItem("مدیریت دسته بندی محصولات", (o, e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.ProductCategories.List>();
            });
            productMenu.AddMenuItem("مدیریت پارامترها", (o, e) =>
            {
                MainViewHandler().OpenTab<Parsys.WinClient.Views.EntityManagerForms.ProductParameters.List>();
            });















            MainMenuStripHandler().AddMenuItem("خروج", (o, e) =>
            {
                if (MessageBox.Show("آیا مایل به خروج از برنامه هستید؟", "پیام سیستم", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            });

            


            


        }
    }
}

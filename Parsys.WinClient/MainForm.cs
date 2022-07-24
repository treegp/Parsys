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

            var menuStrip = new MenuStripHandler(MainMenuStrip.Items);

            var opMenu = menuStrip.AddMenuItem("عملیات");
            opMenu.AddMenuItem("ورود");
            //opMenu.AddMenuItem("-");
            opMenu.AddMenuItem("خروج");


        }
    }
}

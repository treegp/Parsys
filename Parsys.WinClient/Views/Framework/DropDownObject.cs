using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class DropDownObject : UserControl
    {
        public DropDownObject()
        {
            InitializeComponent();
        }

        private void DropDownButton_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = Color.Gainsboro;
            form.Width = 400;
            form.Height = 400;
            form.ShowInTaskbar = false;
            form.TopMost = true;

            form.Show();



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class Editor : ViewBaseControl
    {
        public Editor()
        {
            InitializeComponent();
            
            Id = "EditorCorporation";
            Title = "ویرایش شرکت/سازمان";
            MultipleInstance=false;
        }

        public string caption;

        private void button1_Click(object sender, EventArgs e)
        {
            ViewManagement.OpenTab<Add>(i =>
            {
                i.Id += textBox1.Text;
                i.Title += textBox1.Text;
            });
        }
    }
}

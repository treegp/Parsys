using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class Editor : ViewBaseControl
    {
        public Editor()
        {
            InitializeComponent();
            Id = "EditorCorporation";
            Title = "ویرایش شرکت/سازمان";
            MultipleInstance = false;

            AddButtun("ویرایش شرکت", b => { MessageBox.Show("منوی ویرایش"); });
            AddButtun("حذف شرکت", b => { MessageBox.Show("آیا حذف شود؟"); });
            AddButtun("افزودن شرکت", b => { MessageBox.Show("مشتری جدید"); });



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

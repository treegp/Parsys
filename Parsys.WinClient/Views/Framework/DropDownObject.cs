using System;
using System.Drawing;
using System.Windows.Forms;
using StructureMap.Graph;

namespace Parsys.WinClient.Views.Framework
{
    public partial class DropDownObject : UserControl
    {
        public Form Form;
        public Func<Control> ControlObject;

        public DropDownObject()
        {
            InitializeComponent();
            Form = new Form();
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.BackColor = Color.Gainsboro;
            Form.Width = this.Width;
            Form.Height = this.Width;
            Form.ShowInTaskbar = false;
            Form.TopMost = true;





        }

        private void DropDownButton_Click(object sender, EventArgs e)
        {
            var locationInScreen = this.PointToScreen(Point.Empty);


            if (Form.Visible)
                Form.Hide();
            else
                Form.Show();





            Form.Location = locationInScreen;
            Form.Top += this.Height;


        }
    }
}

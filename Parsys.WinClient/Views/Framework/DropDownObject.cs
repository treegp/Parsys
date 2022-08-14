using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class DropDownObject : UserControl
    {
        public Func<Control> ControlObject;
        public string ReturnString { get { return ValueMaskedTextBox.Text; } set { ValueMaskedTextBox.Text = value; } }
        public string ReturnMask { get { return ValueMaskedTextBox.Mask; } set { ValueMaskedTextBox.Mask = value; } }

        public DropDownObject()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }


        private void DropDownButton_Click(object sender, EventArgs e)
        {
            var locationInScreen = this.PointToScreen(Point.Empty);

            Form form = new Form();

            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = Color.Gainsboro;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.Width = this.Width;
            form.Height = this.Width;
            form.Show();
            form.Location = locationInScreen;
            form.Top += this.Height;

            var ctrl = ControlObject.Invoke();
            form.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;

            form.Deactivate += (s, a) =>
            {
                form.Close();

            };



        }
    }
}

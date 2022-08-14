using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class DropDownObject : UserControl
    {
        public Func<Control> ControlObject;
        public object ReturnObject = null;
        public string ReturnString { get { return ValueMaskedTextBox.Text; } set { ValueMaskedTextBox.Text = value; } }
        public string ReturnMask { get { return ValueMaskedTextBox.Mask; } set { ValueMaskedTextBox.Mask = value; } }
        public Form DropDownForm;

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

            DropDownForm = new Form();

            DropDownForm.FormBorderStyle = FormBorderStyle.None;
            DropDownForm.BackColor = Color.Gainsboro;
            DropDownForm.ShowInTaskbar = false;
            DropDownForm.TopMost = true;
            DropDownForm.Width = this.Width;
            DropDownForm.Height = this.Width;
            DropDownForm.Show();
            DropDownForm.Location = locationInScreen;
            DropDownForm.Top += this.Height;

            var ctrl = ControlObject.Invoke();
            DropDownForm.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;

            DropDownForm.Deactivate += (s, a) =>
            {
                DropDownForm.Close();
                DropDownForm = null;

            };



        }

        public void CloseDropDown()
        {
            if (DropDownForm != null)
                DropDownForm.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class ViewBaseControl : UserControl
    {

        public string Title { get; set; }
        public string Id { get; set; }
        public bool MultipleInstance { get; set; } = false;
        public ViewHandler ViewManagement { get; internal set; }



        protected void CloseThis(DialogResult? result=null)
        {
            ViewManagement.CloseView(this,result);
        }


        protected Button AddButtun(string title,Action<Button> onPress)
        {
            ButtonsPanel.Visible=true;
            int bottunsCount = ButtonsPanel.Controls.Count;
            int left = 20 + (90 + 5) * bottunsCount;
            var btn = new Button();
            btn.Text = title;
            btn.Click += (o,e) => onPress(btn);
            btn.Size = new System.Drawing.Size(90, 25);
            btn.Location = new System.Drawing.Point(left, 6);
            ButtonsPanel.Controls.Add(btn);
            return btn;
        }

        public ViewBaseControl()
        {
            InitializeComponent();
        }

      
    }
}

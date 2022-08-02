using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class ViewBaseControl : UserControl
    {

        public string Title { get; set; }
        public string Id { get; set; }
        public bool MultipleInstance { get; set; } = false;
        public ViewHandler ViewManagement { get; internal set; }

        public ViewBaseControl()
        {
            InitializeComponent();
        }
    }
}

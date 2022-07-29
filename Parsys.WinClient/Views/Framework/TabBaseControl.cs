using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class TabBaseControl : UserControl
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public bool MultipleInstance { get; set; } = false;

        public TabBaseControl()
        {
            InitializeComponent();
        }
    }
}

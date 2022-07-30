using System.Windows.Forms;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class List : ViewBaseControl
    {
        public List()
        {
            InitializeComponent();
            Id = "CorporationList";
            Title = "لیست شرکت ها";
            MultipleInstance = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ViewManagement.OpenTab<Editor>(c=>c.caption="آی دی 12");
        }
    }
}

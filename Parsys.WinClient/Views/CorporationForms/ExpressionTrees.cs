using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class ExpressionTrees : Form
    {
        public ExpressionTrees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<int, int> function = n => n * 2;

        }
    }

    public class MyExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
    {
        override  
    }
}

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
            var n = System.Linq.Expressions.Expression.Parameter(typeof(int), "num");
            var cons = System.Linq.Expressions.Expression.Constant(2);

            var exp = System.Linq.Expressions.Expression.Multiply(n, cons);

            var lambda = System.Linq.Expressions.Expression.Lambda<Func<int, int>>(exp,n);

            MessageBox.Show(lambda.Compile()(5).ToString());

        }
    }
}

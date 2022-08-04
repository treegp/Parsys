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


            var toString = System.Linq.Expressions.Expression.Call(exp, typeof(object).GetMethod("ToString"));

            var lambda = System.Linq.Expressions.Expression.Lambda<Func<int, string>>(toString, n);

            MessageBox.Show(lambda.Compile()(5));

        }
    }
}

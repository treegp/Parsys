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
            var n1 = System.Linq.Expressions.Expression.Parameter(typeof(int), "num1");
            var n2 = System.Linq.Expressions.Expression.Parameter(typeof(int), "num2");

            var addExpression = System.Linq.Expressions.Expression.Add(n1, n2);
            var divExpression = System.Linq.Expressions.Expression.Divide(n1, n2);

            var finalExpression = System.Linq.Expressions.Expression.Multiply(addExpression, divExpression);
            var lambdaExpression = System.Linq.Expressions.Expression.Lambda<Func<int, int, int>>(finalExpression, n1, n2);




            Func<int, int, int> add = lambdaExpression.Compile();

            MessageBox.Show(add(12, 6).ToString());

        }
    }
}

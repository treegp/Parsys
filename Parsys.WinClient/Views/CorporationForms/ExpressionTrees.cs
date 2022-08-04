using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Func<int,int,int> add = (num1,num2) => num1 + num2;
            
            MessageBox.Show(add(2,6).ToString());

        }
    }
}

using System;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class ExpressionTrees : Form
    {
        public Employee Emp { get; set; }


        public ExpressionTrees()
        {
            InitializeComponent();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            return;
            
        }

        private void ExpressionTrees_Load(object sender, EventArgs e)
        {
            NameTextBox.DataBindings.Add("Text", Emp, "Name");
            CountryTextBox.DataBindings.Add("Text", Emp, "Address.Country");
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }


    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}

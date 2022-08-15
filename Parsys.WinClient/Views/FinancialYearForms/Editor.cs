using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.FinancialYearForms
{
    public partial class Editor : EntityEditorClass<FinancialYears>
    {
        private DataLayer.Connections.ProviderMethods.ConnectToSQL con = new DataLayer.Connections.ProviderMethods.ConnectToSQL();
        private FinancialYearsRepository yearRepo;
        private CorporationsRepository corpRepo;

        public Editor()
        {
            InitializeComponent();
            Id = "EditFinancialYears";
            Title = "";
            MultipleInstance = false;


            yearRepo = new FinancialYearsRepository(con.GetConnection());
            corpRepo = new CorporationsRepository(con.GetConnection());

        }
    }
}

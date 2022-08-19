using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.EntityManagerForms.FinancialYears
{
    public partial class Editor : EntityEditorClass<DataLayer.Entities.EntityModels.FinancialYears>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public FinancialYearsRepository Repo;
        public CorporationsRepository corpRepo;


        public Editor()
        {

            InitializeComponent();

            Repo = new FinancialYearsRepository(con.GetConnection());
            corpRepo = new CorporationsRepository(con.GetConnection());

            Title = "";
            Id = "FinancialYearsEditor";
            MultipleInstance = false;


        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NewComboBox(i => i.CorporationId, "عنوان شرکت", corpRepo.GetByIsDeleted(false), c => c.Title, c => c.Id);
            NewTextBox(i => i.Title, "عنوان");
            NewTextBox(i => i.Description, "توضیحات", true);
            var sdp =NewDatePicker(i => i.StartDate, "تاریخ ابتدای دوره");
            sdp.RightToLeft = RightToLeft.No;
            var fdp =NewDatePicker(i => i.FinishDate, "تاریخ انتهای دوره");
            fdp.RightToLeft = RightToLeft.No;
            NewBinaryBox(i => i.IsClosed, "بسته شده");

            ArrangementControls();

        }
    }
}

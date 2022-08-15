using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.FinancialYearForms
{
    public partial class List : ViewBaseControl
    {
        private DataLayer.Connections.ProviderMethods.ConnectToSQL con = new DataLayer.Connections.ProviderMethods.ConnectToSQL();
        public FinancialYearsRepository yearRepo;
        public CorporationsRepository corpRepo;

        GridHandler<FinancialYears> grid;

        public List()
        {
            InitializeComponent();
            Id = "ListFinancialYears";
            Title = "لیست سالهای مالی";
            MultipleInstance = false;

            yearRepo = new FinancialYearsRepository(con.GetConnection());
            corpRepo = new CorporationsRepository(con.GetConnection());


            AddButtun("جدید", b =>
            {
                var form = ViewManagement.ShowForm<Editor>(edt => edt.Title = "تعریف سال مالی جدید", true);
                var t = new FinancialYears();
                if (((Form)form.Parent).DialogResult == DialogResult.OK)
                {
                    t = yearRepo.Insert(form.Entity);
                    grid.AddItem(t);
                }
            });

            AddButtun("ویرایش", b =>
            {

            });


            AddButtun("حذف", b =>
            {

            });
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridHandler<FinancialYears>(this, yearRepo.GetAll());

            grid.AddStringColumn(c => c.Id, "شناسه");
            grid.AddStringColumn(c => corpRepo.GetById(c.CorporationId), "عنوان شرکت");
            grid.AddStringColumn(c => c.Title, "عنوان سال مالی");
            grid.AddStringColumn(c => c.StartDate, "تاریخ افتتاح");
            grid.AddStringColumn(c => c.FinishDate, "تاریخ پایان");
            base.OnLoad(e);
        }
    }
}

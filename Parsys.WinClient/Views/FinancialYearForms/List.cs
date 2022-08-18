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
                var form = ViewManagement.ShowForm<Editor>(frm => frm.Title = "تعریف سال مالی جدید", true);
                var t = new FinancialYears();
                if (((Form)form.Parent).DialogResult == DialogResult.OK)
                {
                    t = yearRepo.Insert(form.Entity);
                    grid.AddItem(t);
                }
            });

            AddButtun("ویرایش", b => { EditButton(); });


            AddButtun("حذف", b =>
            {
                if (grid.CurrentItem == null)
                {
                    MessageBox.Show("سطری انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("آیا قصد حذف " + grid.CurrentItem.Title + " را دارید", "حذف",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    yearRepo.Delete(grid.CurrentItem);
                    grid.RefreshDataSource(yearRepo.GetAll());
                }
            });



        }

        public void EditButton()
        {
            if (grid.CurrentItem == null)
            {
                MessageBox.Show("سطری انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = ViewManagement.ShowForm<Editor>(frm =>
            {
                frm.Title = "ویرایش سال مالی";
                frm.Entity = grid.CurrentItem;
            }, true);

            var t = new FinancialYears();
            if (((Form)form.Parent).DialogResult == DialogResult.OK)
            {
                t = yearRepo.Update(form.Entity);
                grid.UpdateItem(t);
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            grid = new GridHandler<FinancialYears>(this, yearRepo.GetAll());
            grid.OnDoubleClick += (o, a) => { EditButton(); };

            grid.AddStringColumn(c => c.Id, "شناسه");
            grid.AddStringColumn(c => corpRepo.GetById(c.CorporationId), "عنوان شرکت");
            grid.AddStringColumn(c => c.Title, "عنوان سال مالی");
            grid.AddStringColumn(c => c.StartDate, "تاریخ افتتاح");
            grid.AddStringColumn(c => c.FinishDate, "تاریخ پایان");


            base.OnLoad(e);
        }
    }
}

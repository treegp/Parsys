﻿using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.EntityManagerForms.FinancialYears
{


    public partial class List : ViewBaseControl
    {
        private Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        private FinancialYearsRepository repo;
        private CorporationsRepository corpRepo;
        private GridHandler<DataLayer.Entities.EntityModels.FinancialYears> grid;

        public List()
        {
            InitializeComponent();
            repo = new FinancialYearsRepository(con.GetConnection());
            corpRepo = new CorporationsRepository(con.GetConnection());

            grid = new GridHandler<DataLayer.Entities.EntityModels.FinancialYears>(this, repo.GetByIsDeleted(false));

            Title = "لیست سال های مالی";
            Id = "FinancialYearsList";
            MultipleInstance = false;

            AddButtun("جدید", b =>
            {
                var newForm = ViewManagement.ShowForm<Editor>((nw) =>
                {
                    nw.Entity = new DataLayer.Entities.EntityModels.FinancialYears();
                    nw.Title = "تعریف سال مالی جدید";
                }, true);

                if (((Form)newForm.Parent).DialogResult == DialogResult.OK)
                {
                    repo.Insert(newForm.Entity);
                    grid.AddItem(newForm.Entity);
                }


            });

            AddButtun("ویرایش", b =>
            {
                onDoubleClick();
            });

            AddButtun("حذف", b =>
            {
                if (grid.CurrentIndex == -1)
                {
                    MessageBox.Show("سطری انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("آیا از حذف \"" + grid.CurrentItem.Title + "\" اطمینان دارید", "پیام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grid.CurrentItem.IsDeleted = true;
                    grid.CurrentItem.DeleteDate = DateTime.Now;
                    repo.Update(grid.CurrentItem);
                    grid.RemoveItem(grid.CurrentIndex);
                }


            });
        }

        protected void onDoubleClick()
        {
            if (grid.CurrentIndex == -1)
            {
                MessageBox.Show("سطری انتخاب نشده است", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var edtView = ViewManagement.ShowForm<Editor>(edt =>
            {
                edt.Entity = grid.CurrentItem;
                edt.Title = "ویرایش سال مالی";
            }, true);


            if (((Form)edtView.Parent).DialogResult == DialogResult.OK)
            {
                repo.Update(edtView.Entity);
                grid.UpdateItem(edtView.Entity, grid.CurrentIndex);
            }

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            grid.OnDoubleClick += (s, a) => { onDoubleClick(); };


            grid.AddStringColumn(i => i.Title, "عنوان");
            grid.AddStringColumn(i => i.StartDate, "تاریخ ابتدا");
            grid.AddStringColumn(i => i.FinishDate, "تاریخ انتها");
            grid.AddStringColumn(i => i.CorporationId, "شرکت");
            grid.AddStringColumn(i => i.IsClosed, "بسته شده");
            grid.AddStringColumn(i => i.Description, "توضیحات");



        }
    }
}

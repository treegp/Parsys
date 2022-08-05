using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class List : ViewBaseControl
    {
        public List()
        {
            InitializeComponent();
            Id = "CorporationList";
            Title = "لیست شرکت ها";
            MultipleInstance = true;

            AddButtun("ویرایش مشتری", b => { ViewManagement.OpenTab<Editor>(); });

        }

        protected override void OnLoad(EventArgs e)
        {
            List<Products> products = new List<Products>();
            products.Add(new Products() { Id = 1, Title = "محصول یک", Code = "One", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول دو", Code = "Two", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول سه", Code = "Three", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول چهار", Code = "Four", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول پنج", Code = "Five", Description = "ندارد" });



            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.AutoGenerateColumns=false;
            grid.MultiSelect=false;
            grid.DataSource=products;

            

            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "آی دی",
                DataPropertyName = "Id"
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "عنوان",
                DataPropertyName = "Title"
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "کد محصول",
                DataPropertyName = "Code"
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "توضیحات",
                DataPropertyName = "Description"
            });


            this.Controls.Add(grid);


        }

    }
}

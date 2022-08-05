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
            AddButtun("مشاهده انبار ها", b => { ViewManagement.OpenTab<InventoryForms.List>(); });

        }

        protected override void OnLoad(EventArgs e)
        {
            List<Products> products = new List<Products>();
            products.Add(new Products() { Id = 1, Title = "محصول یک", Code = "One", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول دو", Code = "Two", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول سه", Code = "Three", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول چهار", Code = "Four", Description = "ندارد" });
            products.Add(new Products() { Id = 1, Title = "محصول پنج", Code = "Five", Description = "ندارد" });



            var gridManager = new GridHandler<Products>(this, products);

            gridManager.AddStringColumn(c => c.Id,"شناسه");
            gridManager.AddStringColumn(c => c.Title, "عنوان");
            gridManager.AddStringColumn(c => c.Code);
            gridManager.AddStringColumn(c => c.Description, "توضیحات");

        }

    }
}

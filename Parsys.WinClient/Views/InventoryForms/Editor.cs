using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.InventoryForms
{
    public class Editor : EntityEditorClass<Inventories>
    {

        public Editor()
        {

            Id = "EditInventories";
            MultipleInstance = false;
            Title = "";
        }

        protected override void OnLoad(EventArgs e)
        {
            newTextBox(entity => entity.Title, "عنوان انبار");

            newTextBox(entity => entity.Description, "توضیحات");

            base.OnLoad(e);
        }
    }
}

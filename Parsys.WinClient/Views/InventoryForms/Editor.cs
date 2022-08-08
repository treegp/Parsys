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
            Title = "";
            MultipleInstance = false;
        }

    }
}

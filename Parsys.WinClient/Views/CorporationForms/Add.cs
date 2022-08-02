using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.CorporationForms
{
    public partial class Add : ViewBaseControl
    {
        


        public Add()
        {
            InitializeComponent();
            
            
            Id = "AddCorporation";
            Title = "افزودن شرکت / سازمان با کد ";
            MultipleInstance=false;

            
                
        }
    }
}

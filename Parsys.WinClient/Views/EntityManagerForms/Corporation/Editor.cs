using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.EntityManagerForms.Corporation
{
    public partial class Editor : EntityEditorClass<Corporations>
    {


        public Editor()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



        }
    }
}

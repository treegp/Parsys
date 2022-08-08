using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public class EntityEditorClass<TEntity> : ViewBaseControl where TEntity : class, new()
    {
        public TEntity Entity { get; set; }


        public EntityEditorClass()
        {

            Entity = new TEntity();
            AddButtun("تائید", b => CloseThis(DialogResult.OK));
            AddButtun("صرف نظر", b => CloseThis(DialogResult.Cancel));
        }



    }
}

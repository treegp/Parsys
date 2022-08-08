using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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



        protected TextBox newTextBox<TReturn>(Expression<Func<TEntity,TReturn>> item,string caption)
        {
            Label label = new Label();
            label.Text = caption;

            TextBox textBox = new TextBox();




            this.Controls.Add(label);
            this.Controls.Add(textBox);
            return textBox;
        }


        protected ComboBox newComboBox<TReturn,TComboItem>(Expression<Func<TEntity,TReturn>> item, string caption,List<TComboItem> comboList,Expression<Func<TComboItem,string>> comboTitle,Expression<Func<TComboItem,TReturn>> comboItem)
        {
            Label label = new Label();
            label.Text = caption;

            ComboBox comboBox = new ComboBox();



            return null;
        }


    }
}

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


        protected void ArrangementControls()
        {

        }


        protected TextBox NewTextBox<TReturn>(Expression<Func<TEntity,TReturn>> item,string caption)
        {
            var exp = new ExpressionHandler();

            Label label = new Label();
            label.Text = caption;
            label.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.DataBindings.Add("Text", Entity, exp.GetNameOfProperty(item));



            this.Controls.Add(label);
            this.Controls.Add(textBox);
            return textBox;
        }


        protected ComboBox NewComboBox<TReturn,TComboItem>(Expression<Func<TEntity,TReturn>> item, string caption,List<TComboItem> comboList,Expression<Func<TComboItem,string>> comboTitles,Expression<Func<TComboItem,TReturn>> comboItems)
        {
            var exp = new ExpressionHandler();

            Label label = new Label();
            label.Text = caption;
            label.AutoSize = true;

            ComboBox comboBox = new ComboBox();
            comboBox.DataSource = comboList;
            comboBox.DataBindings.Add("SelectedValue", Entity, exp.GetNameOfProperty(item));
            comboBox.DisplayMember = exp.GetNameOfProperty(comboTitles);
            comboBox.ValueMember = exp.GetNameOfProperty(comboItems);




            this.Controls.Add(label);
            this.Controls.Add(comboBox);
            return comboBox;
        }



        
    }
}

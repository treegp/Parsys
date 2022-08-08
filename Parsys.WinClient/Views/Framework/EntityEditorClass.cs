using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public class EntityEditorClass<TEntity> : ViewBaseControl where TEntity : class, new()
    {
        public TEntity Entity { get; set; }
        public List<EntityEditorControl> PriorityList = new List<EntityEditorControl>();


        public EntityEditorClass()
        {

            Entity = new TEntity();
            AddButtun("تائید", b => CloseThis(DialogResult.OK));
            AddButtun("صرف نظر", b => CloseThis(DialogResult.Cancel));
        }


        protected void ArrangementControls()
        {
            if (this.Parent.GetType() == typeof(Form))
                this.Parent.Width = 600;

            int gap = PriorityList.Select(i => i.label.Width).Max();
            int top = 25;

            foreach (var item in PriorityList.OrderBy(p => p.priority))
            {
                item.control.Left = 10;
                item.control.Width = this.Width - gap - 30;
                item.control.Top = top - 3;
                item.control.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                item.label.Left = this.Width - gap - 10;
                item.label.Top = top;
                item.label.Anchor = (AnchorStyles.Right | AnchorStyles.Top);


                top += item.control.Height + 7;
            }

            

            PriorityList.OrderBy(p => p.priority).First().control.Select();


            if (this.Parent.GetType() == typeof(Form))
            {
                this.Parent.Height = top + this.Controls.OfType<Panel>().First().Height +
                                     SystemInformation.CaptionHeight + 30; //i dont understand what cause this 30 pixel
                ((Form)this.Parent).MaximizeBox = false;
                ((Form)this.Parent).MaximumSize = new Size(3000, this.Parent.Height);
                ((Form)this.Parent).MinimumSize = new Size(600, this.Parent.Height);
            }
        }


        protected TextBox NewTextBox<TReturn>(Expression<Func<TEntity, TReturn>> item, string caption,
            bool multiLine = false)
        {
            var exp = new ExpressionHandler();

            Label label = new Label();
            label.Text = caption;
            label.AutoSize = true;

            TextBox textBox = new TextBox();

            textBox.Multiline = multiLine;
            textBox.Width = 80;

            if (multiLine)
            {
                textBox.Height = 90;
                textBox.ScrollBars = ScrollBars.Vertical;
            }


            textBox.DataBindings.Add("Text", Entity, exp.GetNameOfProperty(item));




            this.Controls.Add(label);
            this.Controls.Add(textBox);

            PriorityList.Add(new EntityEditorControl()
            {
                label = label,
                control = textBox,
                priority = PriorityList.Count + 1
            });

            return textBox;
        }


        protected ComboBox NewComboBox<TReturn, TComboItem>(Expression<Func<TEntity, TReturn>> item, string caption, List<TComboItem> comboList, Expression<Func<TComboItem, string>> comboTitles, Expression<Func<TComboItem, TReturn>> comboItems)
        {
            var exp = new ExpressionHandler();

            Label label = new Label();
            label.Text = caption;
            label.AutoSize = true;

            ComboBox comboBox = new ComboBox();

            comboBox.Width = 80;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.DataBindings.Add("SelectedValue", Entity, exp.GetNameOfProperty(item));
            comboBox.DataSource = comboList;
            comboBox.DisplayMember = exp.GetNameOfProperty(comboTitles);
            comboBox.ValueMember = exp.GetNameOfProperty(comboItems);




            this.Controls.Add(label);
            this.Controls.Add(comboBox);

            PriorityList.Add(new EntityEditorControl()
            {
                label = label,
                control = comboBox,
                priority = PriorityList.Count + 1
            });
            return comboBox;
        }




    }

    public class EntityEditorControl
    {
        public Label label { get; set; }
        public Control control { get; set; }
        public int priority { get; set; }
    }
}

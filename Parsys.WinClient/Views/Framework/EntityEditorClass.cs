using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public class EntityEditorClass<TEntity> : ViewBaseControl where TEntity : class, new()
    {
        public TEntity Entity { get; set; }
        public List<EntityEditorControl> PriorityList = new List<EntityEditorControl>();

        private TEntity defaultEntity = new TEntity();

        public EntityEditorClass()
        {

            Entity = new TEntity();
            AddButtun("تائید", b => CloseThis(DialogResult.OK));
            AddButtun("صرف نظر", b =>
            {
                CloseThis(DialogResult.Cancel);
                CopyEntity(defaultEntity, Entity);
            });
            Load += (s, e) => CopyEntity(Entity, defaultEntity);
        }

        private void CopyEntity(TEntity copy, TEntity paste)
        {
            var properties = copy.GetType().GetProperties();
            foreach (var property in properties)
            {
                property.SetValue(paste, property.GetValue(copy));
            }
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


        protected ComboBox NewBinaryBox(Expression<Func<TEntity, bool>> item, string caption)
        {
            List<ComboItem<bool>> comboList = new List<ComboItem<bool>>();
            comboList.Add(new ComboItem<bool>() { DisplayMember = "بلی", ValueMember = true });
            comboList.Add(new ComboItem<bool>() { DisplayMember = "خیر", ValueMember = false });

            return NewComboBox(item, caption, comboList, c => c.DisplayMember, c => c.ValueMember);
        }



        protected DropDownObject NewDatePicker(Expression<Func<TEntity, DateTime>> item, string caption)
        {
            var exp = new ExpressionHandler();

            Label label = new Label();
            label.Text = caption;
            label.AutoSize = true;

            DropDownObject drp = new DropDownObject();
            drp.ReturnMask = "0000/00/00";
            drp.ReturnString = ((DateTime)Entity.GetType().GetProperty(exp.GetNameOfProperty(item)).GetValue(Entity)).ToString("yyyyMMdd");

            drp.RightToLeft = RightToLeft.No;

            drp.ControlObject = () =>
            {
                var datePicker = new DatePickerControl();

                try
                {
                    if (int.Parse(drp.ReturnString.Substring(0, 4)) > 1330 & int.Parse(drp.ReturnString.Substring(0, 4)) < 1430)

                        datePicker.ReturnDate = new DateTime(int.Parse(drp.ReturnString.Substring(0, 4)), int.Parse(drp.ReturnString.Substring(5, 2)), int.Parse(drp.ReturnString.Substring(8, 2)), new System.Globalization.PersianCalendar());
                    else
                        datePicker.ReturnDate = (DateTime)drp.ReturnObject;
                }
                catch
                {
                    if (drp.ReturnObject != null)
                        datePicker.ReturnDate = (DateTime)drp.ReturnObject;
                }




                datePicker.OnChoose += (obj, e) =>
                {
                    drp.ReturnString = datePicker.ReturnDate.ToString("yyyyMMdd");
                    drp.ReturnObject = datePicker.ReturnDate;
                    Entity.GetType().GetProperty(exp.GetNameOfProperty(item)).SetValue(Entity, datePicker.ReturnDate);
                    drp.CloseDropDown();
                };


                return datePicker;

            };


            this.Controls.Add(label);
            this.Controls.Add(drp);

            PriorityList.Add(new EntityEditorControl()
            {
                label = label,
                control = drp,
                priority = PriorityList.Count + 1
            });
            return drp;

        }

        public class EntityEditorControl
        {
            public Label label { get; set; }
            public Control control { get; set; }
            public int priority { get; set; }
        }

        public class ComboItem<TValue>
        {
            public string DisplayMember { get; set; }
            public TValue ValueMember { get; set; }
        }
    }
}
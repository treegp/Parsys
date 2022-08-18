using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{

    public class MenuStripHandler
    {
        private ToolStripItemCollection itemsHierarchy;

        public MenuStripHandler(ToolStripItemCollection collection)
        {
            itemsHierarchy = collection;
        }

        public MenuStripHandler AddMenuItem(string caption)
        {
            return AddMenuItem(caption, null, null);
        }

        public MenuStripHandler AddMenuItem(string caption, EventHandler e)
        {
            return AddMenuItem(caption, null, e);
        }


        public MenuStripHandler AddMenuItem(string caption, Image thumbnail, EventHandler e)
        {
            if (caption == "-")
            {
                AddMenuSeperator();
                return null;
            }

            var menu = (ToolStripMenuItem)itemsHierarchy.Add(caption, thumbnail, e);
            return new MenuStripHandler(menu.DropDownItems);
        }

        public void AddMenuSeperator()
        {
            itemsHierarchy.Add("-");
        }
    }





    public class ViewHandler
    {
        private Dictionary<string, object> openedSingleViews = new Dictionary<string, object>();
        private TabControl instanceTabControl;



        public ViewHandler() { }
        public ViewHandler(TabControl t)
        {
            instanceTabControl = t;


        }


        public T OpenTab<T>(Action<T> initializer = null, bool notUsed = false) where T : ViewBaseControl
        {

            var instance = Activator.CreateInstance<T>();

            if (initializer != null)
                initializer(instance);

            if (!instance.MultipleInstance & openedSingleViews.ContainsKey(instance.Id))
            {
                TabPage tab = (TabPage)openedSingleViews[instance.Id];
                instanceTabControl.SelectedTab = tab;
            }
            else
            {
                instance.ViewManagement = this;
                TabPage tab = new TabPage(instance.Title);
                tab.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                instanceTabControl.TabPages.Add(tab);
                instanceTabControl.SelectedTab = tab;
                if (!instance.MultipleInstance)
                    openedSingleViews.Add(instance.Id, tab);
                else
                {
                    int i = 0;
                    var w = openedSingleViews.Where(k => k.Key.Substring(0, k.Key.Length - 3) == instance.Id);
                    if (w.Count() != 0)
                    {
                        var s = w.Select(k => int.Parse(k.Key.Substring(k.Key.Length - 3)));
                        i = s.Max();
                    }

                    instance.Id += (i + 1).ToString("000");
                    openedSingleViews.Add(instance.Id, tab);
                }
            }

            return instance;
        }


        public T ShowForm<T>(Action<T> initializer = null, bool isDialog = false) where T : ViewBaseControl
        {
            var instance = Activator.CreateInstance<T>();

            if (initializer != null)
                initializer(instance);


            if (!instance.MultipleInstance & openedSingleViews.ContainsKey(instance.Id))
            {
                Form form = (Form)openedSingleViews[instance.Id];
                form.Activate();
            }
            else
            {


                instance.ViewManagement = this;
                Form form = new Form();
                form.Text = instance.Title;
                form.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                form.Width = 800;
                form.Height = 600;
                form.StartPosition = FormStartPosition.CenterParent;
                form.RightToLeft = RightToLeft.Yes;
                form.Font = new Font("Tahoma", 8);
                form.FormClosing += (openedSingleViews, e) => CloseView(instance, form.DialogResult);



                if (!instance.MultipleInstance)
                    openedSingleViews.Add(instance.Id, form);
                else
                {
                    int i = openedSingleViews.Select(k => k.Key.Substring(0, k.Key.Length - 3)).Count();
                    openedSingleViews.Add(instance.Id + (i + 1).ToString("000"), form);
                }

                if (isDialog)
                    form.ShowDialog();
                else
                    form.Show();
            }


            return instance;


        }



        public void CloseView(ViewBaseControl view, DialogResult? dresult = null)
        {
            if (view == null)
                return;

            string id = view.Id;

            if (!openedSingleViews.ContainsKey(id))
                return;



            if (openedSingleViews[id].GetType().Name == "TabPage")
            {
                instanceTabControl.TabPages.Remove((TabPage)openedSingleViews[id]);
                instanceTabControl.SelectedTab = instanceTabControl.TabPages[instanceTabControl.TabCount - 1];
            }
            else if (openedSingleViews[id].GetType().Name == "Form")

                if (dresult != null & ((Form)openedSingleViews[id]).Modal == true)
                    ((Form)openedSingleViews[id]).DialogResult = dresult.Value;
                else
                    ((Form)openedSingleViews[id]).Close();


            openedSingleViews.Remove(id);
        }





    }



    public class GridHandler<TModel>
    {
        private DataGridView dataGrid;
        private BindingSource bindingSource;
        public TModel CurrentItem { get => (TModel)bindingSource?.Current; }
        public int? CurrentIndex { get => bindingSource?.IndexOf(bindingSource?.Current); }
        public event EventHandler OnDoubleClick;

        public GridHandler(Control container, IEnumerable<TModel> dataSource)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;

            dataGrid = new DataGridView();
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.MultiSelect = false;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToResizeColumns = true;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.DataSource = bindingSource;
            dataGrid.CellDoubleClick+= (s,e)=>
            {
                OnDoubleClick(this, new EventArgs());
            };

            container.Controls.Add(dataGrid);
        }


        public GridHandler<TModel> AddStringColumn<TItem>(Expression<Func<TModel, TItem>> item, string header = null)
        {
            var columnName = new ExpressionHandler().GetNameOfProperty(item);
            if (header == null)
                header = columnName;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = header,
                DataPropertyName = columnName
            });

            return this;
        }


        public GridHandler<TModel> RefreshDataSource(IEnumerable<TModel> dataSource = null)
        {
            if (dataSource != null)
                bindingSource.DataSource = dataSource;

            bindingSource.ResetBindings(true);
            return this;
        }


        public void UpdateItem(TModel entity)
        {
            bindingSource[bindingSource.IndexOf(bindingSource.Current)] = entity;
            RefreshDataSource();
        }



        public void AddItem(TModel entity)
        {
            bindingSource.Add(entity);
            RefreshDataSource();
        }


        public void RemoveItem(int? index)
        {
            if (index != null)
            {
                
                bindingSource.Remove(dataGrid.Rows[(int)index]);
                dataGrid.Rows.RemoveAt((int)index);
                RefreshDataSource();
            }
        }


    }


    public class ExpressionHandler : ExpressionVisitor
    {
        private List<string> memberNames = new List<string>();

        public string GetNameOfProperty(Expression exp)
        {
            memberNames.Clear();
            Visit(exp);
            memberNames.Reverse();
            return string.Join(".", memberNames);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member is MemberInfo)
                memberNames.Add(node.Member.Name);
            return base.VisitMember(node);
        }
    }


}

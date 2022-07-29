using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            var menu = itemsHierarchy.Add("-");
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


        public T OpenTab<T>() where T : ViewBaseControl
        {
            var instance = Activator.CreateInstance<T>();
            if (!instance.MultipleInstance & openedSingleViews.ContainsKey(instance.Id))
            {
                TabPage tab = (TabPage)openedSingleViews[instance.Id];
                instanceTabControl.SelectedTab = tab;
            }
            else
            {

                TabPage tab = new TabPage(instance.Title);
                tab.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                instanceTabControl.TabPages.Add(tab);
                instanceTabControl.SelectedTab = tab;
                if (!instance.MultipleInstance)
                    openedSingleViews.Add(instance.Id, tab);
                else
                {
                    int i = openedSingleViews.Select(k => k.Key.Substring(0, k.Key.Length - 3)).Count();
                    instance.Id += (i + 1).ToString("000");
                    openedSingleViews.Add(instance.Id, tab);
                }
            }

            return instance;
        }


        public T ShowForm<T>() where T : ViewBaseControl
        {
            var instance = Activator.CreateInstance<T>();
            if (!instance.MultipleInstance & openedSingleViews.ContainsKey(instance.Id))
            {
                Form form = (Form)openedSingleViews[instance.Id];
                form.Activate();
            }
            else
            {

                Form form = new Form();
                form.Text = instance.Title;
                form.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                form.Width = 800;
                form.Height = 600;
                form.StartPosition = FormStartPosition.CenterParent;
                form.RightToLeft = RightToLeft.Yes;
                form.Font = new Font("Tahoma", 8);


                if (!instance.MultipleInstance)
                    openedSingleViews.Add(instance.Id, form);
                else
                {
                    int i = openedSingleViews.Select(k => k.Key.Substring(0, k.Key.Length - 3)).Count();
                    openedSingleViews.Add(instance.Id + (i + 1).ToString("000"), form);
                }

                form.Show();
            }


            return instance;


        }

        public T ShowDialogForm<T>() where T : ViewBaseControl
        {
            var instance = Activator.CreateInstance<T>();
            if (!instance.MultipleInstance & openedSingleViews.ContainsKey(instance.Id))
            {
                Form form = (Form)openedSingleViews[instance.Id];
                form.Activate();
            }
            else
            {

                Form form = new Form();
                form.Text = instance.Title;
                form.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                form.Width = 800;
                form.Height = 600;
                form.StartPosition = FormStartPosition.CenterParent;
                form.RightToLeft = RightToLeft.Yes;
                form.Font = new Font("Tahoma", 8);


                if (!instance.MultipleInstance)
                    openedSingleViews.Add(instance.Id, form);
                else
                {
                    int i = openedSingleViews.Select(k => k.Key.Substring(0, k.Key.Length - 3)).Count();
                    openedSingleViews.Add(instance.Id + (i + 1).ToString("000"), form);
                }

                form.ShowDialog();
            }


            return instance;


        }





        public void CloseTab(TabPage tab)
        {
            try
            {
                string id = tab.Controls.OfType<ViewBaseControl>().First().Id;
                if (openedSingleViews.ContainsKey(id))
                    openedSingleViews.Remove(id);
                instanceTabControl.Controls.Remove(tab);
            }
            catch
            {
            }
          

        }




    }































    public class TabControlHandler
    {
        private TabControl tabControler;
        private string TabID;
        private Dictionary<string, TabPage> openTabList = new Dictionary<string, TabPage>();

        public TabControlHandler(TabControl tabControl)
        {
            tabControler = tabControl;

            foreach (TabPage tab in tabControler.TabPages)
            {
                openTabList.Add(tab.Text, tab);
            }


        }


        public void AddTab(string caption)
        {
            var Tab = openTabList.Where(k => k.Key == caption).FirstOrDefault().Value;
            if (Tab == null)
            {
                tabControler.TabPages.Add(caption);
                openTabList.Add(caption, tabControler.TabPages[tabControler.TabPages.Count - 1]);
                tabControler.SelectedTab = tabControler.TabPages[tabControler.TabPages.Count - 1];
            }
            else
            {
                tabControler.SelectedTab = Tab;
            }
        }


        public void RemoveTab(string caption)
        {
            var Tab = openTabList.Where(k => k.Key == caption).FirstOrDefault().Value;
            if (Tab != null)
            {
                tabControler.TabPages.Remove(Tab);
                openTabList.Remove(caption);
            }
        }

    }









}

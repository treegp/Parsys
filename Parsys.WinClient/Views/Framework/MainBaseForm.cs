using System;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class MainBaseForm : Form
    {
        private MenuStripHandler menuManager;
        private ViewHandler viewManager;



        public MainBaseForm()
        {
            InitializeComponent();
            menuManager = new MenuStripHandler(MainMenuStrip.Items);
            viewManager = new ViewHandler(MainTabControl);

            var p = new System.Globalization.PersianCalendar();
            //MainTabPage.Controls.Add(new DatePickerControl(new DateTime(1354,4,11, p)));

            var drp = new DropDownObject();
            MainTabPage.Controls.Add(drp);
            drp.ReturnMask = "0000/00/00";
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


                datePicker.OnChoose += (obj,e) =>
                {
                    drp.CloseDropDown();
                };

                datePicker.OnChange += (e, a) =>
                {
                    drp.ReturnString = datePicker.ReturnDate.ToString("yyyyMMdd");
                    drp.ReturnObject = datePicker.ReturnDate;
                };
                
                return datePicker;
            };


            var dt = MainStatusStrip.Items.Add(DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss"));

            DateTimeTimer.Enabled = true;
            DateTimeTimer.Tick += (obj, e) =>
            {
                dt.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm:ss");
            };


        }

        private void DatePicker_OnChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        //-----------------------------------------------------------------------
        public ViewHandler MainViewHandler()
        {
            return viewManager;
        }


        //-----------------------------------------------------------------------
        public MenuStripHandler MainMenuStripHandler()
        {
            return menuManager;
        }


        //-----------------------------------------------------------------------
        private void CloseCurrentTabButton_Click(object sender, EventArgs e)
        {

            viewManager.CloseView(MainTabControl.SelectedTab.Controls.OfType<ViewBaseControl>().FirstOrDefault());

            //tabManager.RemoveTab(MainTabControl.SelectedTab.Text);
        }
    }





}


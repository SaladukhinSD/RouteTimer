using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteTimer
{
    public partial class ModifyRouteForm : Form
    {
        public ModifyRouteForm()
        {
            InitializeComponent();

            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    object[] dataAllNumbers = helper.AllNumbersRoute();

                    comboBoxNumberRoute.Items.AddRange(dataAllNumbers);
                }
            }
        }

        private void comboBoxNumberRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    listBoxInformationRoute.Items.AddRange(helper.DataAboutRoute(Convert.ToString(comboBoxNumberRoute.SelectedItem)));
                }
            }
        }
        private void listBoxNumberRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    textBoxModifyRoute.Text = Convert.ToString(listBoxInformationRoute.SelectedItem);   
                }
            }
        }

        private void buttonModifyRoute_Click(object sender, EventArgs e)
        {
            List<string> modifyRoute = new List<string> {};
            foreach (object item in listBoxInformationRoute.Items)
            {
                modifyRoute.Add(item.ToString());
            }

            modifyRoute[listBoxInformationRoute.SelectedIndex] = textBoxModifyRoute.Text;
            listBoxInformationRoute.Items[listBoxInformationRoute.SelectedIndex] = textBoxModifyRoute.Text;

            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    helper.ModifyRoute(modifyRoute);

                }
            }
        }
    }
}

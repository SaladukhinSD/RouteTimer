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
    public partial class InformationRouteForm : Form
    {
        public InformationRouteForm()
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
                    textBoxInformationRoute.Text = helper.InformationAboutRoute(Convert.ToString(comboBoxNumberRoute.SelectedItem));
                }
            }
        }
    }
}

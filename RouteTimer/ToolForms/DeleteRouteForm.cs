using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteTimer
{
    public partial class DeleteRouteForm : Form
    {
        public DeleteRouteForm()
        {
            InitializeComponent();
            using (ExcelHelper helper = new ExcelHelper())
            {
                object[] dataAllNumbers = helper.AllNumbersRoute();

                comboBoxNumberRoute.Items.AddRange(dataAllNumbers);
            }

        }

        private void buttonDeliteRoute_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to delite the route?";
            const string caption = "Delite route";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                object selectedNumberRoute = comboBoxNumberRoute.SelectedItem;
                
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                    {
                        try
                        {
                            helper.DeliteRoute(Convert.ToString(selectedNumberRoute));

                            helper.Save();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Enter corected data");
                        }
                    }
                }
            }

        }
    }
}

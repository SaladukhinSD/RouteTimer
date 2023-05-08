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
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            //добавить подсказки для ввода и тект в окне

            string numberR, nameR, directionR, distanceR, kindOfTransportR, allTimeR;
            numberR = textBoxNumberRoute.Text.TrimStart('0', ' ');
            numberR = numberR.TrimEnd();
            nameR = textBoxNameRoute.Text.Trim();
            directionR = textBoxDirectionRoute.Text.Trim();
            distanceR = textBoxDistanceAboutBusStopRoute.Text.Trim();
            kindOfTransportR = textBoxKindOfTransport.Text.Trim();
            allTimeR = textBoxAllTime.Text.Trim(); // добавить проверку на символы

            if(numberR != "" || nameR != "" || directionR != "" || distanceR != "" || kindOfTransportR != "" || allTimeR != "" )
            {
                
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                    {
                        ExcelHelper.Route newRoute = new ExcelHelper.Route(numberR, nameR, directionR, distanceR, kindOfTransportR, allTimeR);

                        helper.AddRoute(newRoute);

                        helper.Save();

                        MessageBox.Show("You add new route");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter all parameters");
            }
        }
    }
}

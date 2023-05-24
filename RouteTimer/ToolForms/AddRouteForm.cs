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
            textBoxNumberRoute.Text = "Number route";
            textBoxNumberRoute.ForeColor = Color.Gray;
            textBoxNameRoute.Text = "Name route";
            textBoxNameRoute.ForeColor = Color.Gray;
            textBoxDirectionRoute.Text = "Direction route";
            textBoxDirectionRoute.ForeColor = Color.Gray;
            textBoxDistanceAboutBusStopRoute.Text = "Distance about bus stop";
            textBoxDistanceAboutBusStopRoute.ForeColor = Color.Gray;
            textBoxKindOfTransport.Text = "Kind of transport";
            textBoxKindOfTransport.ForeColor = Color.Gray;
            textBoxAllTime.Text = "Time";
            textBoxAllTime.ForeColor = Color.Gray;

        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {

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

        private void textBoxNumberRoute_Enter(object sender, EventArgs e)
        {
            if (textBoxNumberRoute.Text == "Number route")
            {
                textBoxNumberRoute.Text = "";
                textBoxNumberRoute.ForeColor = Color.Black;
            }
        }

        private void textBoxNumberRoute_Leave(object sender, EventArgs e)
        {
            if (textBoxNumberRoute.Text == "")
            {
                textBoxNumberRoute.Text = "Number route";
                textBoxNumberRoute.ForeColor = Color.Gray;
            }
        }

        private void textBoxNameRoute_Enter(object sender, EventArgs e)
        {
            if (textBoxNameRoute.Text == "Name route")
            {
                textBoxNameRoute.Text = "";
                textBoxNameRoute.ForeColor = Color.Black;
            }
        }

        private void textBoxNameRoute_Leave(object sender, EventArgs e)
        {
            if (textBoxNameRoute.Text == "")
            {
                textBoxNameRoute.Text = "Name route";
                textBoxNameRoute.ForeColor = Color.Gray;
            }
        }

        private void textBoxDirectionRoute_Enter(object sender, EventArgs e)
        {
            if (textBoxDirectionRoute.Text == "Direction route")
            {
                textBoxDirectionRoute.Text = "";
                textBoxDirectionRoute.ForeColor = Color.Black;
            }
        }

        private void textBoxDirectionRoute_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectionRoute.Text == "")
            {
                textBoxDirectionRoute.Text = "Direction route";
                textBoxDirectionRoute.ForeColor = Color.Gray;
            }
        }

        private void textBoxDistanceAboutBusStopRoute_Enter(object sender, EventArgs e)
        {
            if (textBoxDistanceAboutBusStopRoute.Text == "Distance about bus stop")
            {
                textBoxDistanceAboutBusStopRoute.Text = "";
                textBoxDistanceAboutBusStopRoute.ForeColor= Color.Black;
            }
        }

        private void textBoxDistanceAboutBusStopRoute_Leave(object sender, EventArgs e)
        {
            if (textBoxDistanceAboutBusStopRoute.Text == "")
            {
                textBoxDistanceAboutBusStopRoute.Text = "Distance about bus stop";
                textBoxDistanceAboutBusStopRoute.ForeColor= Color.Gray;
            }
        }

        private void textBoxKindOfTransport_Enter(object sender, EventArgs e)
        {
            if (textBoxKindOfTransport.Text == "Kind of transport")
            {
                textBoxKindOfTransport.Text = "";
                textBoxKindOfTransport.ForeColor= Color.Black;
            }
        }

        private void textBoxKindOfTransport_Leave(object sender, EventArgs e)
        {
            if (textBoxKindOfTransport.Text == "")
            {
                textBoxKindOfTransport.Text = "Kind of transport";
                textBoxKindOfTransport.ForeColor= Color.Gray;
            }
        }

        private void textBoxAllTime_Enter(object sender, EventArgs e)
        {
            if (textBoxAllTime.Text == "Time")
            {
                textBoxAllTime.Text = "";
                textBoxAllTime.ForeColor= Color.Black;
            }
        }

        private void textBoxAllTime_Leave(object sender, EventArgs e)
        {
            if (textBoxAllTime.Text == "")
            {
                textBoxAllTime.Text = "Time";
                textBoxAllTime.ForeColor= Color.Gray;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RouteTimer
{
    public partial class FormMain : Form
    {
        List<ExcelHelper.Route> allData = new List<ExcelHelper.Route>();
        public FormMain()
        {
            InitializeComponent();

            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    listBoxSchedule.Items.AddRange(helper.AllData());
                    
                }

            }
        }

        private void ButtonAddRoute_Click(object sender, EventArgs e)
        {
            AddRouteForm addRoute = new AddRouteForm();
            addRoute.Owner = this;
            addRoute.Show();
        }

        private void buttonModifyRoute_Click(object sender, EventArgs e)
        {
            ModifyRouteForm modRoute = new ModifyRouteForm();
            modRoute.Owner = this;
            modRoute.Show();
        }

        private void buttonDeliteRoute_Click(object sender, EventArgs e)
        {
            DeleteRouteForm delRoute = new DeleteRouteForm();
            delRoute.Owner = this;
            delRoute.Show();
        }

        private void buttonInformationRoute_Click(object sender, EventArgs e)
        {
            InformationRouteForm infRoute = new InformationRouteForm();
            infRoute.Owner = this;
            infRoute.Show();
        }

        private void buttonUserCharacteristics_Click(object sender, EventArgs e)
        {
            CharacteristicsUserForm charRoute = new CharacteristicsUserForm();
            charRoute.Owner = this;
            charRoute.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RouteTimer
{
    public partial class CharacteristicsUserForm : Form
    {
        private int dataSpeed;
        private int dataMinutes;
        private int dataDistance;

        public CharacteristicsUserForm()
        {
            InitializeComponent();

            using (ExcelHelper helper = new ExcelHelper())
            {
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                {
                    textBoxSpeed.Text = helper.Get("A", 2);
                    textBoxMinutes.Text = helper.Get(column: "B", row: 2);
                    textBoxDistance.Text = helper.Get(column: "C", row: 2);
                }
            }
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSpeed.Text.Trim() != "")
                {
                    dataSpeed = Convert.ToInt32(textBoxSpeed.Text.Trim());
                }
                else
                {
                    dataMinutes = Convert.ToInt32(textBoxMinutes.Text.Trim());
                    dataDistance = Convert.ToInt32(textBoxDistance.Text.Trim());
                    dataSpeed = MathValues.calculate(dataMinutes, dataDistance);
                    textBoxSpeed.Text = dataSpeed.ToString();
                }
                
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "DataRouts.xlsx")))
                    {
                        helper.Set(column: "A", row: 2, data: dataSpeed);
                        helper.Set(column: "B", row: 2, data: dataMinutes);
                        helper.Set(column: "C", row: 2, data: dataDistance);
                        helper.Set(column: "D", row: 2, data: DateTime.Now);

                        helper.Save();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Enter your speed or distance and minutes to overcome her!");
            }
            this.DialogResult = DialogResult.OK;
        }

    }
}

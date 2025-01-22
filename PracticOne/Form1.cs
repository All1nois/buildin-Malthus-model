using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Windows.Forms.DataVisualization.Charting;

namespace PracticOne
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try {
                //Настраиваемые поля
                double a = Convert.ToDouble(startYear.Text);
                double b = Convert.ToDouble(endYear.Text);
                double size = Convert.ToDouble(people.Text);
                //Рождаемость
                double BirthPeople = 0.028;
                //Смертность
                double DeathPeople = 0.008;
                //Переменная для вывода результата
                double outcom = 0;



                string s;

                //Область графика
                chart1.ChartAreas.Add(new ChartArea("Метод"));


                Series series = new Series("Численность");
                series.ChartType = SeriesChartType.Line;



                for (double i = a; a <= b; a++)
                {
                    outcom = size + (BirthPeople - DeathPeople) * size;
                    size = outcom;

                    label6.Text = Math.Round(size).ToString();


                    for (double x = -Math.PI; x <= Math.PI; x += Math.PI / 10.0)
                    {
                        series.Points.Add(outcom, Math.Sin(size));


                    }


                }


                chart1.Series.Add(series);

            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }


        }
    }
}

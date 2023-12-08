using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double q; // дебит скважины, объем/время
            double cd; // коэффициент дебита
            double h = Convert.ToDouble(textBox1.Text); // эффективная мощность пласта, длина
            double k = Convert.ToDouble(textBox2.Text); ; // проницаемость пласта, относительная скорость потока
            double g = Convert.ToDouble(textBox3.Text); ; // перепад давления, сила/площадь
            double mu = Convert.ToDouble(textBox4.Text); ; // вязкость флюида, вязкость
            double re; // Reynold's number, безразмерная величина

            // вычисление коэффициента дебита
            cd = 0.00708 * (h / (Math.Sqrt(k) * Math.Log10(g / (mu * 1.8))));

            // расчет дебита скважины по формуле Гигера
            re = (cd * Math.Sqrt(k) * g) / mu;
            q = Math.Round((cd * h * g) / 1.8,3);

            textBox5.Text = Convert.ToString(q);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            double q; // дебит скважины, промысловая (тыс.м3/сут)
            double h = Convert.ToDouble(textBox1.Text); // продуктивная толщина пласта (м)
            double k = Convert.ToDouble(textBox2.Text); // проницаемость пласта (мд)
            double deltaP = Convert.ToDouble(textBox3.Text); // перепад давления (атм)

            // расчёт дебита по формуле Джоши
            q = Math.Round( 11.22 * k * h * Math.Sqrt(deltaP),3);

            textBox4.Text = Convert.ToString(q);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }
    }
}

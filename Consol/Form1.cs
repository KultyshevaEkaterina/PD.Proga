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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(TextBoxk.Text);
            double h = Convert.ToDouble(textBoxh.Text);
            double d = Convert.ToDouble(TextBoxd.Text);
            double q;

            // вычисляем дебит скважины
            q = Math.Round(0.001 * k * h * Math.PI * Math.Pow(d, 2) / 8.34,3);
            textBoxRes.Text = Convert.ToString(q);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }

        private void k_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

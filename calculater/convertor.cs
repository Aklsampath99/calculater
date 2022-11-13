using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class convertor : Form
    {
        public convertor()
        {
            InitializeComponent();
        }

        private void convertor_Load(object sender, EventArgs e)
        {

        }

        private void convertor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uNITConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convert_click(object sender, EventArgs e)
        {

            if (ctext.Text != "")
            {
                double celsius = Double.Parse(ctext.Text);
                double fahrenheit = ((celsius * 9) / 5) + 32;
                double kelvin = celsius + 273.15;

                ftext.Text = celsius.ToString();
                ktext.Text = kelvin.ToString();
            }
            else if (ftext.Text != "")
            {
                double fahrenheit = Double.Parse(ftext.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                double kelvin = (fahrenheit + 459.67) * 5 / 9;

                ctext.Text = celsius.ToString();
                ktext.Text = kelvin.ToString();
            }
            else if (ktext.Text != "")
            {
                double kelvin = Double.Parse(ktext.Text);
                double celsius = kelvin - 273.15;
                double fahrenheit = (kelvin * 9 / 5) - 459.67;

                ctext.Text = celsius.ToString();
                ktext.Text = kelvin.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ctext.Text = "";
            ftext.Text = "";
            ktext.Text = "";
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void uNITConverterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unit_convertor uconvertor = new unit_convertor();
            this.Hide();
            uconvertor.ShowDialog();
        }
    }
}

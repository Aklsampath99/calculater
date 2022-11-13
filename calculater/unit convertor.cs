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
    public partial class unit_convertor : Form
    {
        public unit_convertor()
        {
            InitializeComponent();
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void temperatureConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convertor convertor = new convertor();
            this.Hide();
            convertor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( from.SelectedItem == to.SelectedItem)
            {
                ansertextbox.Text = value_enter_text_box.Text;
            }
            if (from.SelectedItem == "Meter (m)" && to.SelectedItem == "Centimeter (cm)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) * 100).ToString();
            }
            if (from.SelectedItem == "Centimeter (cm)" && to.SelectedItem == "Meter (m)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) / 100).ToString();
            }
            if (from.SelectedItem == "Meter (m)" && to.SelectedItem == "Kilometer (Km)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) / 1000).ToString();
            }
            if (from.SelectedItem == "Kilometer (Km)" && to.SelectedItem == "Meter (m)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) * 1000).ToString();
            }
            if (from.SelectedItem == "Centimeter (cm)" && to.SelectedItem == "Kilometer (Km)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) / 100000).ToString();
            }
            if (from.SelectedItem == "Kilometer (Km)" && to.SelectedItem == "Centimeter (cm)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) * 100000).ToString();
            }
            if (from.SelectedItem == "gram (g)" && to.SelectedItem == "Kilogram (Kg)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) / 1000).ToString();
            }
            if (from.SelectedItem == "Kilogram (Kg)" && to.SelectedItem == "gram (g)")
            {
                ansertextbox.Text = (double.Parse(value_enter_text_box.Text) * 1000).ToString();
            }
        }
    }
}

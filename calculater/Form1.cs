using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace calculater
{ 
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool value = false;
        
        public Form1()
        {
           
            InitializeComponent();
           
           


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void standerCalculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 338;
            caltextbox.Width = 298;

        }

        private void scienstificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 688;
            caltextbox.Width = 649;

        }

        private void number_button_click(object sender, EventArgs e)
        {
            if ((caltextbox.Text == "0") || (value))
            
                caltextbox.Text = "0";

                value = false;
                Button num = (Button)sender;
                if (num.Text == ".")
                {
                    if (!caltextbox.Text.Contains("."))
                        caltextbox.Text = caltextbox.Text + num.Text;
                }
            
            else
            {
                caltextbox.Text = caltextbox.Text + num.Text;
            }
        }

        //clear button 
        private void button3_Click_1(object sender, EventArgs e)
        {
           caltextbox.Clear();
        }

        private void backspase_click(object sender, EventArgs e)
        {
            if(caltextbox.Text.Length>0)
            {
                caltextbox.Text = caltextbox.Text.Remove(caltextbox.Text.Length - 1, 1);
            }
            if(caltextbox.Text==" ")
            {
                caltextbox.Text = "0";
            }
        }

        private void oparater_click(object sender, EventArgs e)
        {
            String btntext = ((Button)sender).Text;
            Button num = (Button)sender;
            operation = num.Text;
            if (caltextbox.Text[caltextbox.Text.Length - 1] == '+' || caltextbox.Text[caltextbox.Text.Length - 1] == '-' || caltextbox.Text[caltextbox.Text.Length - 1] == '*' || caltextbox.Text[caltextbox.Text.Length - 1] == '/')
            {
                if (operation != caltextbox.Text[caltextbox.Text.Length - 1].ToString())
                {
                    caltextbox.Text = caltextbox.Text.Remove(caltextbox.Text.Length - 1);
                    btntext = Convert.ToString(caltextbox.Text);
                    caltextbox.Text = System.Convert.ToString(btntext) + operation;
                }
                return;
            }
            btntext = Convert.ToString(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(btntext) + operation;
        }

        private void equal_button_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }

            Console.WriteLine(caltextbox.Text);
            String Equalstr = (caltextbox.Text);

            if (Equalstr[Equalstr.Length - 1] == '+' || Equalstr[Equalstr.Length - 1] == '-' || Equalstr[Equalstr.Length - 1] == '*' || Equalstr[Equalstr.Length - 1] == '/')
            {
                Equalstr = Equalstr.Remove(Equalstr.Length - 1);
            }

           // new DataTable() obj eka callculate
            var FinalResult = Convert.ToDouble(new DataTable().Compute(Equalstr, "") + "");
            Console.WriteLine(FinalResult);
            caltextbox.Text = Math.Round(FinalResult, 5).ToString();

        }

        private void pi_button_click(object sender, EventArgs e)
        {
      
                caltextbox.Text = Math.PI.ToString();
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xlog = Double.Parse(caltextbox.Text);
            xlog = Math.Log10(xlog);
            caltextbox.Text = System.Convert.ToString(xlog);
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }

            Double xSqrt = Double.Parse(caltextbox.Text);
            xSqrt = Math.Sqrt(xSqrt);
            caltextbox.Text = System.Convert.ToString(xSqrt);
        }

        private void sinh_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }

            Double xSinh = Double.Parse(caltextbox.Text);
            xSinh = Math.Sinh(xSinh);
            caltextbox.Text = System.Convert.ToString(xSinh);
        }

        private void sin_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }

            Double xSin = Double.Parse(caltextbox.Text);
            xSin = Math.Sin(xSin);
            caltextbox.Text = System.Convert.ToString(xSin);
        }

        private void dec_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xDec = Double.Parse(caltextbox.Text);
            xDec = Math.Log10(xDec);
            caltextbox.Text = System.Convert.ToString(xDec);
        }

        private void x2_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            double x2;
            x2 = Convert.ToDouble(caltextbox.Text) * Convert.ToDouble(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(x2);
        }

        private void x3_button(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            double x3;
            x3 = Convert.ToDouble(caltextbox.Text) * Convert.ToDouble(caltextbox.Text) * Convert.ToDouble(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(x3);
        }

        private void cosh_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xCosh = Double.Parse(caltextbox.Text);
            xCosh = Math.Cosh(xCosh);
            caltextbox.Text = System.Convert.ToString(xCosh);
        }

        private void cos_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xCos = Double.Parse(caltextbox.Text);
            xCos = Math.Cos(xCos);
            caltextbox.Text = System.Convert.ToString(xCos);
        }

        private void bin_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            int xBin = int.Parse(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(xBin, 2);
        }

        private void x_click(object sender, EventArgs e)
        {
            //1/x button click
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            double x1;
            x1 = Convert.ToDouble(1.0 / Convert.ToDouble(caltextbox.Text));
            caltextbox.Text = System.Convert.ToString(x1);
        }

        private void tanh_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xTanh = Double.Parse(caltextbox.Text);
            xTanh = Math.Tanh(xTanh);
            caltextbox.Text = System.Convert.ToString(xTanh);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //tan button click
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }

            Double xTan = Double.Parse(caltextbox.Text);
            xTan = Math.Tan(xTan);
            caltextbox.Text = System.Convert.ToString(xTan);
        }

        private void hex_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            int xHex = int.Parse(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(xHex, 16);
        }

        private void in_x_click(object sender, EventArgs e)
        {

            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            Double xIn = Double.Parse(caltextbox.Text);
            xIn = Math.Log(xIn);
            caltextbox.Text = System.Convert.ToString(xIn);
        }

        private void exp_click(object sender, EventArgs e)
        {

        }

        private void mod_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            string xMod = "%";
            caltextbox.Text = System.Convert.ToString(caltextbox.Text) + xMod;
        }

        private void oct_click(object sender, EventArgs e)
        {
            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            int xOct = int.Parse(caltextbox.Text);
            caltextbox.Text = System.Convert.ToString(xOct, 8);
        }

        private void presenttage_button_click(object sender, EventArgs e)
        {

            if (caltextbox.Text == "" || caltextbox.Text == "0")
            {
                return;
            }
            double xPercentage;
            xPercentage = Convert.ToDouble(caltextbox.Text) / Convert.ToDouble(100);
            caltextbox.Text = System.Convert.ToString(xPercentage);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //+or- buttn click
            Double result = Double.Parse(caltextbox.Text);
            result = result * -1;
            caltextbox.Text = result.ToString();
        }

        private void convertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           convertor convertor = new convertor();
            this.Hide();
            convertor.ShowDialog();
        }
        
    }
    }

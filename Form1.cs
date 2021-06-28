using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operation;
        int flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            string val_to_erase = labelScreen.Text;
            if (val_to_erase.Length == 1)
            {
                labelScreen.Text = 0.ToString();
            }
            else
            {
                string val = val_to_erase.Substring(0, val_to_erase.Length - 1);
                labelScreen.Text = val.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            labelScreen.Text = 0.ToString();
            labelOperation.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            labelScreen.Text = 0.ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            string recent_val = labelScreen.Text;
            double val = Convert.ToDouble(recent_val)/100;
            labelOperation.Text += $"{val}";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string recent_val = labelScreen.Text;
            int val = Convert.ToInt32(recent_val);
            labelScreen.Text = (-val).ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            string recent_val = labelScreen.Text;
            labelScreen.Text = $"{recent_val},";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operation = labelOperation.Text;
            string leftVal = operation.Substring(0, operation.Length - 2);
            string recentVal = labelScreen.Text;
            labelOperation.Text += $"{labelScreen.Text} = ";
            if (operation.Contains('+'))
            {
                labelScreen.Text = (Convert.ToDouble(leftVal) + Convert.ToDouble(recentVal)).ToString();
            }
            else if(operation.Contains('-'))
            {
                labelScreen.Text = (Convert.ToDouble(leftVal) - Convert.ToDouble(recentVal)).ToString();
            }
            else if (operation.Contains('x'))
            {
                labelScreen.Text = (Convert.ToDouble(leftVal) * Convert.ToDouble(recentVal)).ToString();
            }
            else if(operation.Contains('÷'))
            {
                labelScreen.Text = (Convert.ToDouble(leftVal) / Convert.ToDouble(recentVal)).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"{labelScreen.Text} + ";
            labelScreen.Text = 0.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"{labelScreen.Text} - ";
            labelScreen.Text = 0.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"{labelScreen.Text} x ";
            labelScreen.Text = 0.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"{labelScreen.Text} ÷ ";
            labelScreen.Text = 0.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"√({labelScreen.Text}) ";
            string recent_val = labelScreen.Text;
            double val = Math.Sqrt(Convert.ToDouble(recent_val));
            labelScreen.Text = val.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"sqr({labelScreen.Text}) ";
            string recent_val = labelScreen.Text;
            double val = Math.Pow(Convert.ToDouble(recent_val),2);
            labelScreen.Text = val.ToString();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            labelOperation.Text = $"1/({labelScreen.Text}) ";
            string recent_val = labelScreen.Text;
            double val = 1/Convert.ToDouble(recent_val);
            labelScreen.Text = val.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{0.ToString()}";
            }
            else
            {
                labelScreen.Text = 0.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{1.ToString()}";
            }
            else
            {
                labelScreen.Text = 1.ToString();
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{2.ToString()}";
            }
            else
            {
                labelScreen.Text = 2.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{3.ToString()}";
            }
            else
            {
                labelScreen.Text = 3.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{4.ToString()}";
            }
            else
            {
                labelScreen.Text = 4.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{5.ToString()}";
            }
            else
            {
                labelScreen.Text = 5.ToString();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{6.ToString()}";
            }
            else
            {
                labelScreen.Text = 6.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{7.ToString()}";
            }
            else
            {
                labelScreen.Text = 7.ToString();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{8.ToString()}";
            }
            else
            {
                labelScreen.Text = 8.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text != "0")
            {
                labelScreen.Text = $"{labelScreen.Text}{9.ToString()}";
            }
            else
            {
                labelScreen.Text = 9.ToString();
            }
        }

    }
}

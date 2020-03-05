using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             //creating new veriable 
            decimal FirstQuarter;
            decimal SecondQuarter;
            decimal ThirdQuarter;
            decimal FourthQuarter;

            if (decimal.TryParse(txtFirstQuarter.Text, out FirstQuarter))
            {
                // creating new list 
                List<decimal> bill = new List<decimal>();
                bill.Add(FirstQuarter); // Added new bill
                MessageBox.Show(txtFirstQuarter.Text);

            }
            if (decimal.TryParse(txtSecondQuarter.Text, out SecondQuarter))
            {
                List<decimal> bill = new List<decimal>();
                bill.Add(SecondQuarter);
                MessageBox.Show(txtSecondQuarter.Text);
            }
            if (decimal.TryParse(txtThirdQuarter.Text, out ThirdQuarter))
            {
                List<decimal> bill = new List<decimal>();
                bill.Add(ThirdQuarter);
                MessageBox.Show(txtThirdQuarter.Text);
            }
            if (decimal.TryParse(txtFourthQuarter.Text, out FourthQuarter))
            {
                List<decimal> bill = new List<decimal>();
                bill.Add(FourthQuarter);
                MessageBox.Show(txtFourthQuarter.Text);
            }
            else
            {
                //You will have this message if you use letters

                MessageBox.Show("please type numeric number!");
                txtFirstQuarter.Clear();
                txtSecondQuarter.Clear();
                txtThirdQuarter.Clear();
                txtFourthQuarter.Clear();
            }

            decimal total = FirstQuarter + SecondQuarter + ThirdQuarter + FourthQuarter; 
            decimal averageBill = total / 4;
            txtAverage.Text = averageBill.ToString(); //Average
            txtTotal.Text = Convert.ToString(total);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

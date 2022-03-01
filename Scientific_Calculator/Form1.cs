using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Calculator : Form
    {

        Double results = 0;
        String operations = "";
        bool enter_value = false;
        char iOperation;

    

        public Calculator()
        {
            InitializeComponent();
        }
        

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void hover(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {

        }

        private void four_Click(object sender, EventArgs e)
        {

        }

        private void five_Click(object sender, EventArgs e)
        {

        }

        private void six_Click(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {

        }

        private void yes(object sender, EventArgs e)
        {

        }

        private void thevalue_Click(object sender, EventArgs e)
        {
        }

        private void button_Click(object sender, EventArgs e)
        {

        }



        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
           
            if(results !=0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operations = b.Text;
                lblOperator.Text = results + "   " + operations;
            }
            else
            {
                operations = b.Text;
                results = Double.Parse(thevalue.Text);
                enter_value = true;
                lblOperator.Text = results + "   " + operations;
            }
              

        }

        private void btnDeleteone_Click(object sender, EventArgs e)
        {
            thevalue.Text = "0";

        }

        private void btnDeleteall_Click(object sender, EventArgs e)
        {
            thevalue.Text = "0";
            results = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (thevalue.Text.Length > 0)
            {
                thevalue.Text = thevalue.Text.Remove(thevalue.Text.Length - 1, 1);
            }
            
            if (thevalue.Text == "")
            {
                thevalue.Text = "0";
            }
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((thevalue.Text == "0")|| (enter_value))
                    thevalue.Text = "";
            enter_value = false;

            if (b.Text ==".")
            {
                if (!thevalue.Text.Contains("."))
                    thevalue.Text = thevalue.Text + b.Text;
            }
            else
            {
                thevalue.Text = thevalue.Text + b.Text;
            }
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            lblOperator.Text = "";
            switch (operations)
            {
                case "+":
                    thevalue.Text = (results + Double.Parse(thevalue.Text)).ToString();
                    break;
                case "-":
                    thevalue.Text = (results - Double.Parse(thevalue.Text)).ToString();
                    break;
                case "x":
                    thevalue.Text = (results * Double.Parse(thevalue.Text)).ToString();
                    break;
                case "/":
                    thevalue.Text = (results / Double.Parse(thevalue.Text)).ToString();
                    break;

                default:
                    break;
            }
            results = Double.Parse(thevalue.Text);
            operations = "";
        }

        private void btnPlusorminus_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = results * -1;
            thevalue.Text = results.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Sqrt(results);

            thevalue.Text = results.ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = results / 100;
            thevalue.Text = results.ToString();
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Pow(results, 2);
            thevalue.Text = results.ToString();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Pow(results, 3);
            thevalue.Text = results.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Log10(results);
            thevalue.Text = results.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Sin(results);
            thevalue.Text = results.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Cos(results);
            thevalue.Text = results.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Tan(results);
            thevalue.Text = results.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            results = Math.PI;
            thevalue.Text = results.ToString();
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Exp(results);
            thevalue.Text = results.ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Tanh(results);
            thevalue.Text = results.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Cosh(results);
            thevalue.Text = results.ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Sinh(results);
            thevalue.Text = results.ToString();
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            results = double.Parse(thevalue.Text);
            results = Math.Log(results);
            thevalue.Text = results.ToString();
        }
    }
    }



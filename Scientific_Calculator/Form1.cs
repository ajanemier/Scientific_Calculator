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
        public Calculator()
        {
            InitializeComponent();
        }

        private void graphinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (thevalue.Text == "0")
            {
                thevalue.Text = " ";
            }
            thevalue.Text = thevalue.Text + "9";

        }

        private void yes(object sender, EventArgs e)
        {

        }

        private void thevalue_Click(object sender, EventArgs e)
        {
        }
    }
}

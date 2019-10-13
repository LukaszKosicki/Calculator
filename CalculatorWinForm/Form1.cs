using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        double _dresult;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button1.Text : equation.Text += button1.Text;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button2.Text : equation.Text += button2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button3.Text : equation.Text += button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button4.Text : equation.Text += button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button5.Text : equation.Text += button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button6.Text : equation.Text += button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button7.Text : equation.Text += button7.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button8.Text : equation.Text += button8.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button9.Text : equation.Text += button9.Text;
        }

        //0
        private void Button10_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button10.Text : equation.Text += button10.Text;
        }

        //-
        private void Button12_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button12.Text : equation.Text += button12.Text;

        }

        //+
        private void Button13_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button13.Text : equation.Text += button13.Text;
        }

        //*
        private void Button14_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button14.Text : equation.Text += button14.Text;
        }

        //%
        private void Button15_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button15.Text : equation.Text += button15.Text;
        }

        //=
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                _dresult = Convert.ToDouble(new DataTable().Compute(equation.Text, null));
            }
            catch
            {
                MessageBox.Show("Wpisałeś jakieś głupoty. Nie da się tego obliczyć!!", "Fatal Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            result.Text = _dresult.ToString();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            _dresult = 0;
            result.Text = "0";
            equation.Text = "0";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button17.Text : equation.Text += button17.Text;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button18.Text : equation.Text += button18.Text;
        }

        // /
        private void Button19_Click(object sender, EventArgs e)
        {
            equation.Text = (equation.Text == "0" || equation.Text == null) ? button19.Text : equation.Text += button19.Text;
        }
    }
}

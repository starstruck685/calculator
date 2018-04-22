using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcufuckinglator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        Boolean operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operation_pressed))
                textBox1.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "X":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
            operation_pressed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
        }
    }
}

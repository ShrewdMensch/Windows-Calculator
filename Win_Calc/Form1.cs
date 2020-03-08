using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        private double value;
        string operation;
        bool operator_pressed = false;
        bool equals_pressed= false;

        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void button_click(object sender, EventArgs e)
        {
            
            if ((result.Text == "0") || (operator_pressed) || (equals_pressed))
                result.Text = " ";
            Button b = (Button)sender;
            result.Text= result.Text + b.Text;
           operator_pressed = false;
           equals_pressed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            operator_pressed = true;
            value = double.Parse(result.Text);
            Button b = (Button)sender;
            operation = b.Text;
            label1.Text = result.Text +" " + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            operator_pressed = true;
             equals_pressed = false;
            switch(operation) {
                case "+" :
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value /double.Parse(result.Text)).ToString();
                    break;

                case "x":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;

            } //End switch
            
        }

       

        

       

        

       

       
    }
}

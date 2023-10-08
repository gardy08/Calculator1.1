using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1._1
{
    public partial class Form1 : Form
    {
        string selectedoperator;
        int acumulatedvalue;

        public Form1()
        {
            InitializeComponent();
        }

        //we give them event to each number by the value of the button 

        //we create a new method 
        private void NumberAction_Click(object sender, EventArgs e) //the parameter is variable string 
        {
            Button button = (Button)sender;
            int buttonvalue=int.Parse(button.Text); //keep the value 
            int currentvalue = int.Parse(textBox1.Text); //keep the current value
            currentvalue = currentvalue * 10 + buttonvalue;

            textBox1.Text = currentvalue.ToString();
        }

        //we create a new method for the operator 
        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
             selectedoperator = button.Text;

             acumulatedvalue = int.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        //the button clear 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "0";
        }

        //the button equal
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            int secondAcumulatedvalue = int.Parse(textBox1.Text); //that's the second value 
            int result = 0;

            switch (selectedoperator)
            {
                case "+":
                    result = acumulatedvalue + secondAcumulatedvalue;
                    break;
                case "-":
                    result = acumulatedvalue - secondAcumulatedvalue;
                    break;
                case "*":
                    result = acumulatedvalue * secondAcumulatedvalue;
                    break;
                case "/":
                    result = acumulatedvalue / secondAcumulatedvalue;
                    break;

            }

            textBox1.Text = result.ToString();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Calculate : Form
    {

        //declare variables for user input and result 
        double a = 0; 
        double b = 0;  
        string option = "";
        double result = 0.0; 

        public Calculate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      

        }

        private void firstNumberPrompt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FirstNumber_Click(object sender, EventArgs e)
        {

        }

        private void secondNumber_Click(object sender, EventArgs e)
        {

        }

        private void secondNumberPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectOperation_Click(object sender, EventArgs e)
        {

        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(firstNumberPrompt.Text);
            b = Convert.ToDouble(secondNumberPrompt.Text);
            option = Convert.ToString(OperationTextBox.Text);

            if (option.Equals("+"))
            { 
                result = a + b;
                outputLabel.Text = result.ToString();
            } else if (option.Equals("-"))
            {
                result = a - b;
                outputLabel.Text = result.ToString();

            } else if (option.Equals("*"))

            {
                result = a * b;
                outputLabel.Text = result.ToString();
            } else
            {
                outputLabel.Text = "Error: Please check operation symbol."; 
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void OperationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

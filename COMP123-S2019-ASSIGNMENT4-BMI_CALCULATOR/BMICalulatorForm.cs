using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_ASSIGNMENT4_BMI_CALCULATOR
{
    
    public partial class BMICalculatorForm : Form
    {
        /// <summary>
        /// This is the contructor Method
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// This is an event handler for imperial radio button checked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked == true)
            {
                MetricRadioButton.Checked = false;
            }
            MyHeightTextBox.Text = "inches";
            MyHeightTextBox.ForeColor = Color.LightSteelBlue;
            MyWeightTextBox.Text = "pounds";
            MyWeightTextBox.ForeColor = Color.LightSteelBlue;


        }
        /// <summary>
        /// This is an event handler for metric radio button checked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked == true)
            {
                ImperialRadioButton.Checked = false;
            }
            MyHeightTextBox.Text = "cm";
            MyHeightTextBox.ForeColor = Color.LightSteelBlue;
            MyWeightTextBox.Text = "kg";
            MyWeightTextBox.ForeColor = Color.LightSteelBlue;

        }
        //This is an event handler for MyHeightTextBox click event 
        private void MyHeightTextBox_Click(object sender, EventArgs e)
        {
            MyHeightTextBox.Text = "";
            MyHeightTextBox.ForeColor = Color.Black;
  
        }
        /// <summary>
        /// This is an event handler for MyWeigthTextBox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWeightTextBox_Click(object sender, EventArgs e)
        {
            MyWeightTextBox.Text = "";
            MyWeightTextBox.ForeColor = Color.Black;
        }
        /// <summary>
        /// This is an event handler for Calculatorbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

            double weight;
            double height;

            weight = double.Parse(MyWeightTextBox.Text);
            height = double.Parse(MyHeightTextBox.Text);

            //Condition when Imperial radiobutton is checked
            ImperialCalculation(weight, height);

            //Condition when Metric radio button is checked
            MetricCalculation(weight, height);
        }

        private void MetricCalculation(double weight, double height)
        {
            if (MetricRadioButton.Checked)
            {
                double bmi = weight / (height / 100.0 * height / 100.0);
                BMIOutputLabel.Text = Math.Round(bmi, 2).ToString();

                if (bmi < 18.5 && bmi >= 0)
                {
                    BMICategoryOutputBox.BackColor = Color.LightBlue;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "Your are underweight!";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    BMICategoryOutputBox.BackColor = Color.Green;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "You are normal weight!";
                }
                else if (bmi >= 25.0 && bmi <= 29.9)
                {
                    BMICategoryOutputBox.BackColor = Color.Orange;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "You are overweight!";
                }
                else
                {
                    BMICategoryOutputBox.BackColor = Color.Red;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "Your are obese!";
                }
            }
        }

        private void ImperialCalculation(double weight, double height)
        {
            if (ImperialRadioButton.Checked)
            {
                double bmi = (weight * 703.0) / (height * height);
                BMIOutputLabel.Text = Math.Round(bmi, 2).ToString();

                if (bmi < 18.5 && bmi >= 0)
                {
                    BMICategoryOutputBox.BackColor = Color.LightBlue;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "Your are underweight!";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    BMICategoryOutputBox.BackColor = Color.Green;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "You are normal weight!";
                }
                else if (bmi >= 25.0 && bmi <= 29.9)
                {
                    BMICategoryOutputBox.BackColor = Color.Orange;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "You are overweight!";
                }
                else
                {
                    BMICategoryOutputBox.BackColor = Color.Red;
                    BMICategoryOutputBox.ForeColor = Color.White;
                    BMICategoryOutputBox.Text = "Your are obese!";
                }
            }
        }

        /// <summary>
        /// This is an even Handler for ResetButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            MyHeightTextBox.Text = "inches";
            MyHeightTextBox.ForeColor = Color.LightSteelBlue;
            MyWeightTextBox.Text = "pounds";
            MyWeightTextBox.ForeColor = Color.LightSteelBlue;
            BMICategoryOutputBox.Text = "";
            BMICategoryOutputBox.BackColor = Color.White;
            BMIOutputLabel.Text = "";
        }

        

      
    }
}

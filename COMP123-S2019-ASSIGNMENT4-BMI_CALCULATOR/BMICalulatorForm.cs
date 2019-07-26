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
        public static double weight;
        public static double height;
        public static double bmi;
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
            if (ImperialRadioButton.Checked)
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
            if (MetricRadioButton.Checked)
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
            try
            {
                height = double.Parse(MyHeightTextBox.Text);
                weight = double.Parse(MyWeightTextBox.Text);
                //Condition when Imperial radio button is checked
                if (ImperialRadioButton.Checked && MyHeightTextBox.Text != string.Empty && MyWeightTextBox.Text != string.Empty)
                {
                    ImperialCalculation(weight, height);
                }

                //Condition when Metric radio button is checked
                if (MetricRadioButton.Checked && MyHeightTextBox.Text != string.Empty && MyWeightTextBox.Text != string.Empty)
                {
                    MetricCalculation(weight, height);
                }
            } 
            catch (System.FormatException)
            {              
                    ErrorMessageLabel.Text = "please enter valid input";
                    ErrorMessageLabel.Visible = true;  
            }
            
            
        }
        /// <summary>
        /// Metric calculation method
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        private void MetricCalculation(double weight, double height)
        {
            bmi = weight / (height / 100.0 * height / 100.0);
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
                BMICategoryOutputBox.Text = "You are obese!";
            }

        }
       /// <summary>
       /// Imperial calculation method
       /// </summary>
       /// <param name="weight"></param>
       /// <param name="height"></param>
    private void ImperialCalculation(double weight, double height)
    {
        bmi = weight * 703 / (height * height);
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
            ImperialRadioButton.Checked = true;
            ErrorMessageLabel.Visible = false;

        }
        /// <summary>
        /// This is an event handler for validating MyHeightTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (ImperialRadioButton.Checked && MyHeightTextBox.Text==string.Empty)
            {
                ErrorMessageLabel.Text = "please enter your height";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;           
            }
            else if (MetricRadioButton.Checked && MyHeightTextBox.Text == string.Empty)
            {
                ErrorMessageLabel.Text = "please enter your height";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if(ImperialRadioButton.Checked && double.TryParse(MyHeightTextBox.Text,out height)==false)
            {
                ErrorMessageLabel.Text = "please enter numbers only";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if (MetricRadioButton.Checked && double.TryParse(MyHeightTextBox.Text, out height) == false)
            {
                ErrorMessageLabel.Text = "please enter numbers only";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if (ImperialRadioButton.Checked && MyHeightTextBox.Text != string.Empty && double.Parse(MyHeightTextBox.Text) > 100)
            {             
                    ErrorMessageLabel.Text = "please enter your correct height";
                    ErrorMessageLabel.Visible = true;
                    e.Cancel = true;          
            }
            else if (MetricRadioButton.Checked && MyHeightTextBox.Text != string.Empty && double.Parse(MyHeightTextBox.Text) > 250)
            {
                ErrorMessageLabel.Text = "please enter your correct height";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }

        }
        
        /// <summary>
        /// This is an event handler for validating MyweightTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWeightTextBox_Validating(object sender, CancelEventArgs e)
        {
           
            if (ImperialRadioButton.Checked && MyWeightTextBox.Text == string.Empty)
            {
                ErrorMessageLabel.Text = "please enter your weight";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
             

            }
            else if (MetricRadioButton.Checked && MyWeightTextBox.Text == string.Empty)
            {
                ErrorMessageLabel.Text = "please enter your weight";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;

            }
            else if (ImperialRadioButton.Checked && double.TryParse(MyWeightTextBox.Text, out height) == false)
            {
                ErrorMessageLabel.Text = "please enter numbers only";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if (MetricRadioButton.Checked && double.TryParse(MyWeightTextBox.Text, out height) == false)
            {
                ErrorMessageLabel.Text = "please enter numbers only";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if (ImperialRadioButton.Checked && MyWeightTextBox.Text != string.Empty && double.Parse(MyWeightTextBox.Text) > 1600)
            {
                ErrorMessageLabel.Text = "please enter your correct weight";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }
            else if (MetricRadioButton.Checked && MyWeightTextBox.Text != string.Empty && double.Parse(MyWeightTextBox.Text) > 700)
            {
                ErrorMessageLabel.Text = "please enter your correct weight";
                ErrorMessageLabel.Visible = true;
                e.Cancel = true;
            }

        }
        /// <summary>
        /// This event handler occur when the validation is successed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightTextBox_Validated(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
        }

        private void MyWeightTextBox_Validated(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
        }
        /// <summary>
        /// This is an event handler for form click close button in the window form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

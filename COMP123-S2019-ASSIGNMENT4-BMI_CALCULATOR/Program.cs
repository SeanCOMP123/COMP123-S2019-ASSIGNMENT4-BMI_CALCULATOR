using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*---------------------------------------------------
 * Student name: Sean(Myoung seop) Kwak
 * Student number: 300614352
 * Name of Assignment: BMI Calculator
 * Date of creation: 2019-07-20
 * Last day of revision: 2019-07-25
 * --------------------------------------------------*/
namespace COMP123_S2019_ASSIGNMENT4_BMI_CALCULATOR
{
    static class Program
    {
        public static Dictionary<FormType, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormType, Form>();
            Forms.Add(FormType.START_FORM, new StartForm()); //add startform
            Forms.Add(FormType.MAIN_FORM, new BMICalculatorForm()); //add BMI_calculator form
            Application.Run(new StartForm()); //run startform for splash screen
        }
    }
}

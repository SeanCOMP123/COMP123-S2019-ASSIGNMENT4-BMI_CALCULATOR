using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Forms.Add(FormType.START_FORM, new StartForm());
            Forms.Add(FormType.MAIN_FORM, new BMICalculatorForm());
            Application.Run(new StartForm());
        }
    }
}

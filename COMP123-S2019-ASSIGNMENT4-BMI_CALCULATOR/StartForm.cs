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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is an event handler for splash timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormType.MAIN_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event handler for startform load and progress bar increment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            this.LoadingProgressBar.Increment(100);
        }
    }
}

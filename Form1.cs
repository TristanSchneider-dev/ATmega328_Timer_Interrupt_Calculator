using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATmega328_Timer_Interrupt_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare variables
        decimal time;
        decimal frequency;
        int speed;
        enum prescaler
        {
            a = 1, 
            b = 8, 
            c = 64, 
            d = 256, 
            e = 1024
        }
        decimal compare;

        //Value Changes methods
        private void n_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_frequency_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_speed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_prescaler_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_compare_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

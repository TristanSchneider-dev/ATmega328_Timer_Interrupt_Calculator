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
        //Declare variables
        public decimal time;
        public decimal frequency;
        public decimal speed;
        public decimal prescaler;
        public decimal compare;

        public decimal top;
        public decimal tc;
        
        public Form1()
        {
            InitializeComponent();
        }

        //Calc Methods
        decimal m_time ()
        {
            frequency = n_frequency.Value;
            time = 1 / frequency;
            return time;
        }

        decimal m_frequency ()
        {
            time = n_time.Value;
            frequency = 1 / time;
            return frequency;
        }

        decimal m_compare ()
        {
            frequency = n_frequency.Value;
            speed = n_speed.Value;
            prescaler = n_prescaler.Value;

            bool z = false;
            int timer = 65536;
                        
            do //Prescaler selection
            {
                switch (prescaler)
                {
                    case 1:
                        top = speed / prescaler;  //Timer TOP
                        tc = top / frequency;  //Compare register

                        if (tc < top && top < timer)
                        {
                            compare = tc;
                            z = true; //End of loop
                        }
                        else
                        {
                            prescaler = 8;
                        }
                        break;

                    case 8:
                        top = speed / prescaler;
                        tc = top / frequency;

                        if (tc < top && top < timer)
                        {
                            compare = tc;
                            z = true;
                        }
                        else
                        {
                            prescaler = 64;
                        }
                        break;

                    case 64:
                        top = speed / prescaler;
                        tc = top / frequency;

                        if (tc < top && top < timer)
                        {
                            compare = tc;
                            z = true;
                        }
                        else
                        {
                            prescaler = 256;
                        }
                        break;

                    case 256:
                        top = speed / prescaler;
                        tc = top / frequency;

                        if (tc < top && top < timer)
                        {
                            compare = tc;
                            z = true;
                        }
                        else
                        {
                            prescaler = 1024;
                        }
                        break;

                    case 1024:
                        top = speed / prescaler;
                        tc = top / frequency;

                        if (tc < top && top < timer)
                        {
                            compare = tc;
                            z = true;
                        }
                        else
                        {
                            Console.WriteLine("KeinPrescaler gefunden!");
                        }
                        break;

                    default:
                        //If wrong prescaler selected
                        prescaler = 1;
                        break;
                }

            } while (z == false);

            return compare;
        }

        //Value Changes methods
        private void n_time_ValueChanged(object sender, EventArgs e)
        {
            n_frequency.Value = m_frequency();
        }

        private void n_frequency_ValueChanged(object sender, EventArgs e)
        {
            n_time.Value = m_time();
            n_compare.Value = m_compare();
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

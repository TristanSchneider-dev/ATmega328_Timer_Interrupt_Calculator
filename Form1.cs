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

        public decimal x;
        public decimal y;
        public byte z;

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
            
            do //Bis prescaler gefunden ist
            {
                switch (prescaler)
                {
                    case 1:
                        x = speed / prescaler;  //Timer TOP
                        y = x / frequency;  //TOP : desired Hz = Compare

                        if (x < y) //Wenn Copare > Top = Neuer größerer prescaler
                        {
                            prescaler = 8;
                        }
                        else
                        {
                            compare = y;
                            z = 1; //Ende der schleife
                        }
                        break;

                    case 8:
                        x = speed / prescaler;  //Timer TOP
                        y = x / frequency;  //TOP : desired Hz = Compare

                        if (x < y) //Wenn Copare > Top = Neuer größerer prescaler
                        {
                            prescaler = 64;
                        }
                        else
                        {
                            compare = y;
                            z = 1; //Ende der schleife
                        }
                        break;

                    case 64:
                        x = speed / prescaler;  //Timer TOP
                        y = x / frequency;  //TOP : desired Hz = Compare

                        if (x < y) //Wenn Copare > Top = Neuer größerer prescaler
                        {
                            prescaler = 256;
                        }
                        else
                        {
                            compare = y;
                            z = 1; //Ende der schleife
                        }
                        break;

                    case 256:
                        x = speed / prescaler;  //Timer TOP
                        y = x / frequency;  //TOP : desired Hz = Compare

                        if (x < y) //Wenn Copare > Top = Neuer größerer prescaler
                        {
                            prescaler = 1024;
                        }
                        else
                        {
                            compare = y;
                            z = 1; //Ende der schleife
                        }
                        break;

                    case 1024:
                        x = speed / prescaler;  //Timer TOP
                        y = x / frequency;  //TOP : desired Hz = Compare

                        if (x < y) //Wenn Copare > Top = Neuer größerer prescaler
                        {
                            //ENDE KEIN PRESCALER GEFUNDEN
                        }
                        else
                        {
                            compare = y;
                            z = 1; //Ende der schleife
                        }
                        break;

                    default:
                        //Wenn Prescaler falsch gewählt
                        prescaler = 1;
                        break;
                }

            } while (z == 0);

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
        }

        private void n_speed_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void n_prescaler_ValueChanged(object sender, EventArgs e)
        {
            decimal x;
            x = m_compare();
        }

        private void n_compare_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

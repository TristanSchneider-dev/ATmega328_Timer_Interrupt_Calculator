using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATmega328_Timer_Interrupt_Calculator
{
    public partial class Form1 : Form
    {
        //Declare variables
        public decimal time;
        public decimal frequency;
        public decimal speed;
        public int prescaler;
        public decimal compare;

        public int timer = 65536;
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

        int m_prescaler()
        {
            decimal period;
            decimal top;
            decimal prescaler_min;
            speed = n_speed.Value;
            time = n_time.Value;

            btn_remove();

            period = 1 / speed; //period in ns
            top = time / period;
            prescaler_min = top / timer;

            if (prescaler_min > 0 && prescaler_min < 1)
            {
                prescaler = 1;
                m_button("1");
                m_button("8");
                m_button("64");
                m_button("256");
                m_button("1024");
            }
            else if (prescaler_min > 1 && prescaler_min < 8)
            {
                prescaler = 8;
                m_button("8");
                m_button("64");
                m_button("256");
                m_button("1024");
            }
            else if (prescaler_min > 8 && prescaler_min < 64)
            {
                prescaler = 64;
                m_button("64");
                m_button("256");
                m_button("1024");
            }
            else if (prescaler_min > 64 && prescaler_min < 256)
            {
                prescaler = 256;
                m_button("256");
                m_button("1024");
            }
            else if (prescaler_min > 256 && prescaler_min < 1024)
            {
                prescaler = 1024;
                m_button("1024");
            }
            else
            {
                //No prescaler found
            }

            return prescaler;
        }

        //decimal m_prescaler_old()
        //{
        //    frequency = n_frequency.Value;
        //    speed = n_speed.Value;

        //    btn_remove();

        //    bool z = false;

        //    do //Prescaler selection
        //    {
        //        switch (prescaler)
        //        {
        //            default:
        //                //If wrong prescaler selected
        //                prescaler = 1;
        //                break;

        //            case 1:
        //                top = speed / prescaler;  //Timer TOP
        //                tc = top / frequency;  //Compare register

        //                if (tc < top && top < timer)
        //                {
        //                    z = true; //End of loop

        //                    m_compare(prescaler);

        //                    m_button(prescaler.ToString());
        //                    m_button("8");
        //                    m_button("64");
        //                    m_button("256");
        //                    m_button("1024");
        //                }
        //                else
        //                {
        //                    prescaler = 8;
        //                }
        //                break;

        //            case 8:
        //                top = speed / prescaler;
        //                tc = top / frequency;

        //                if (tc < top && top < timer)
        //                {
        //                    z = true;

        //                    m_compare(prescaler);

        //                    m_button(prescaler.ToString());
        //                    m_button("64");
        //                    m_button("256");
        //                    m_button("1024");
        //                }
        //                else
        //                {
        //                    prescaler = 64;
        //                }
        //                break;

        //            case 64:
        //                top = speed / prescaler;
        //                tc = top / frequency;

        //                if (tc < top && top < timer)
        //                {
        //                    z = true;

        //                    m_compare(prescaler);

        //                    m_button(prescaler.ToString());
        //                    m_button("256");
        //                    m_button("1024");
        //                }
        //                else
        //                {
        //                    prescaler = 256;
        //                }
        //                break;

        //            case 256:
        //                top = speed / prescaler;
        //                tc = top / frequency;

        //                if (tc < top && top < timer)
        //                {
        //                    z = true;

        //                    m_compare(prescaler);

        //                    m_button(prescaler.ToString());
        //                    m_button("1024");
        //                }
        //                else
        //                {
        //                    prescaler = 1024;
        //                }
        //                break;

        //            case 1024:
        //                top = speed / prescaler;
        //                tc = top / frequency;

        //                z = true;

        //                m_compare(prescaler);

        //                m_button(prescaler.ToString());

        //                break;
        //        }

        //    } while (z == false);

        //    return prescaler;
        //}

        void m_compare(int pre)
        {
            frequency = n_frequency.Value;
            speed = n_speed.Value;

            top = speed / pre;  //Timer TOP
            compare = top / frequency;  //Compare register

            if(timer > compare)
            {
                t_compare.Text = compare.ToString();
            }
            else
            {
                btn_remove();
                t_compare.Text = "ERROR";
            }
            
        }

        public void m_button(string pre)
        {
            Button btn = new Button();
            btn.Name = pre;
            btn.Text = pre;
            btn.Height = 30;
            btn.Width = 60;
            btn.Font = new Font("Calibri", 10);
            btn.Click += new System.EventHandler(Button_Click);
            this.f_buttons.Controls.Add(btn);
        }

        public void btn_remove()
        {
            foreach (Button btn in f_buttons.Controls)
            {
                btn.Visible = false;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string button = ((Button)sender).Text;
            m_compare(Convert.ToUInt16(button));
        }

        //Value Changes methods
        private void n_time_ValueChanged(object sender, EventArgs e)
        {
            n_frequency.Value = m_frequency();
            m_prescaler();
        }

        private void n_frequency_ValueChanged(object sender, EventArgs e)
        {
            n_time.Value = m_time();
        }

        private void n_speed_ValueChanged(object sender, EventArgs e)
        {
            m_prescaler();
        }

    }
}

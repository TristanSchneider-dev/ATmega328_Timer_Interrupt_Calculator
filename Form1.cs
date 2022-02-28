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
        public int timer = 65536; //16bit timer
        
        public Form1()
        {
            InitializeComponent();
        }

        //Calc Methods
        decimal m_time () //Calculate time in s
        {
            if (n_frequency.Value != 0)
            {
                frequency = n_frequency.Value;
                time = 1 / frequency;
            }
            else
            {
                t_compare.Text = "ERROR"; //Frequency is zero
            }
            
            return time;
        }

        decimal m_frequency () //Calculate frequency in Hz
        {
            if (n_time.Value != 0 )
            {
                time = n_time.Value;
                frequency = 1 / time;
            }
            else
            {
                t_compare.Text = "ERROR"; //Time is zero
            }
            
            if (frequency > 1000000000) //Overflow fix
            {
                frequency = 0;
            }
            return frequency;
        }

        int m_prescaler() //Check for avaliable prescalers
        {
            decimal period;
            decimal top;
            decimal prescaler_min;
            speed = n_speed.Value;
            time = n_time.Value;

            btn_remove();

            period = 1 / speed; //Period in ns
            top = time / period;
            prescaler_min = top / timer; //Smallest prescaler value

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
                t_compare.Text = "ERROR"; //No prescaler found
            }

            m_compare(prescaler);

            return prescaler;
        }

        void m_compare(int pre) //Calculate compare value
        {
            decimal top;
            decimal compare;

            frequency = n_frequency.Value;
            speed = n_speed.Value;

            top = speed / pre; //Timer TOP
            compare = top / frequency; //Compare register

            if(timer > compare) //Check if compare is bigger than timer
            {
                t_compare.Text = compare.ToString();
            }
            else
            {
                t_compare.Text = "ERROR";
            }
        }

        public void m_button(string pre) //Create dynamic button
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

        public void btn_remove() //Delete buttons on change
        {
            f_buttons.Controls.Clear();
        }

        private void Button_Click(object sender, EventArgs e) //Button click function
        {
            string button = ((Button)sender).Text;
            m_compare(Convert.ToUInt16(button)); //Recalculate prescaler if button is clicked
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

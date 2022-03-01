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
            try
            {
                frequency = Convert.ToDecimal(t_frequency.Text);
                time = 1 / frequency;
            }
            catch
            {
                time = 0;
                t_compare.Text = "ERROR";
            }
            
            return Math.Round(time, 4);
        }

        decimal m_frequency () //Calculate frequency in Hz
        {
            try
            {
                time = Convert.ToDecimal(t_time.Text);
                frequency = 1 / time;
            }
            catch
            {
                frequency = 0;
                t_compare.Text = "ERROR";
            }

            return Math.Round(frequency, 4);
        }

        int m_prescaler() //Check for avaliable prescalers
        {
            decimal period;
            decimal top;
            decimal prescaler_min;
            bool pre_found = false;
            
            btn_remove();

            try
            {
                speed = Convert.ToDecimal(t_speed.Text);
                time = Convert.ToDecimal(t_time.Text);

                period = 1 / speed; //Period in ns
                top = time / period;
                prescaler_min = top / timer; //Smallest prescaler value

                pre_found = true;
            }
            catch
            {
                prescaler_min = 0;
            }

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
                prescaler = 0;
            }

            if(pre_found == true && prescaler_min != 0)
            {
                m_compare(prescaler);
            }
            
            return prescaler;
        }

        void m_compare(int pre) //Calculate compare value
        {
            decimal top;
            decimal compare;

            try
            {
                frequency = Convert.ToDecimal(t_frequency.Text);
                speed = Convert.ToDecimal(t_speed.Text);

                top = speed / pre; //Timer TOP
                compare = top / frequency; //Compare register
            }
            catch
            {
                compare = 0;
            }
            

            if (timer > compare && compare!= 0) //Check if compare is bigger than timer
            {
                t_compare.Text = Math.Round(compare, 4).ToString();
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
        private void t_time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                t_frequency.Text = m_frequency().ToString();
                m_prescaler();
            }
        }

        private void t_frequency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                t_time.Text = m_time().ToString();
                m_prescaler();
            }
        }

        private void t_speed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                m_prescaler();
            }
        }
    }
}

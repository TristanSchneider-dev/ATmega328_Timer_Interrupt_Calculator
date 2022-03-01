
namespace ATmega328_Timer_Interrupt_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_time = new System.Windows.Forms.Label();
            this.l_frequency = new System.Windows.Forms.Label();
            this.l_speed = new System.Windows.Forms.Label();
            this.l_prescaler = new System.Windows.Forms.Label();
            this.l_s = new System.Windows.Forms.Label();
            this.l_hz0 = new System.Windows.Forms.Label();
            this.l_hz1 = new System.Windows.Forms.Label();
            this.l_compare = new System.Windows.Forms.Label();
            this.t_compare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f_buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.p_clock = new System.Windows.Forms.PictureBox();
            this.t_speed = new System.Windows.Forms.TextBox();
            this.t_frequency = new System.Windows.Forms.TextBox();
            this.t_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_time.ForeColor = System.Drawing.Color.Silver;
            this.l_time.Location = new System.Drawing.Point(12, 47);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(205, 21);
            this.l_time.TabIndex = 0;
            this.l_time.Text = "TIME BETWEEN INTERRUPTS";
            // 
            // l_frequency
            // 
            this.l_frequency.AutoSize = true;
            this.l_frequency.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_frequency.ForeColor = System.Drawing.Color.Silver;
            this.l_frequency.Location = new System.Drawing.Point(12, 114);
            this.l_frequency.Name = "l_frequency";
            this.l_frequency.Size = new System.Drawing.Size(174, 21);
            this.l_frequency.TabIndex = 1;
            this.l_frequency.Text = "INTERRUPT FREQUENCY";
            // 
            // l_speed
            // 
            this.l_speed.AutoSize = true;
            this.l_speed.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_speed.ForeColor = System.Drawing.Color.Silver;
            this.l_speed.Location = new System.Drawing.Point(12, 181);
            this.l_speed.Name = "l_speed";
            this.l_speed.Size = new System.Drawing.Size(102, 21);
            this.l_speed.TabIndex = 2;
            this.l_speed.Text = "CLOCK SPEED";
            // 
            // l_prescaler
            // 
            this.l_prescaler.AutoSize = true;
            this.l_prescaler.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_prescaler.ForeColor = System.Drawing.Color.Silver;
            this.l_prescaler.Location = new System.Drawing.Point(12, 248);
            this.l_prescaler.Name = "l_prescaler";
            this.l_prescaler.Size = new System.Drawing.Size(87, 21);
            this.l_prescaler.TabIndex = 3;
            this.l_prescaler.Text = "PRESCALER";
            // 
            // l_s
            // 
            this.l_s.AutoSize = true;
            this.l_s.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_s.ForeColor = System.Drawing.Color.Silver;
            this.l_s.Location = new System.Drawing.Point(178, 82);
            this.l_s.Name = "l_s";
            this.l_s.Size = new System.Drawing.Size(17, 21);
            this.l_s.TabIndex = 10;
            this.l_s.Text = "s";
            // 
            // l_hz0
            // 
            this.l_hz0.AutoSize = true;
            this.l_hz0.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_hz0.ForeColor = System.Drawing.Color.Silver;
            this.l_hz0.Location = new System.Drawing.Point(178, 149);
            this.l_hz0.Name = "l_hz0";
            this.l_hz0.Size = new System.Drawing.Size(28, 21);
            this.l_hz0.TabIndex = 11;
            this.l_hz0.Text = "Hz";
            // 
            // l_hz1
            // 
            this.l_hz1.AutoSize = true;
            this.l_hz1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_hz1.ForeColor = System.Drawing.Color.Silver;
            this.l_hz1.Location = new System.Drawing.Point(178, 216);
            this.l_hz1.Name = "l_hz1";
            this.l_hz1.Size = new System.Drawing.Size(28, 21);
            this.l_hz1.TabIndex = 12;
            this.l_hz1.Text = "Hz";
            // 
            // l_compare
            // 
            this.l_compare.AutoSize = true;
            this.l_compare.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_compare.ForeColor = System.Drawing.Color.Silver;
            this.l_compare.Location = new System.Drawing.Point(12, 351);
            this.l_compare.Name = "l_compare";
            this.l_compare.Size = new System.Drawing.Size(185, 21);
            this.l_compare.TabIndex = 13;
            this.l_compare.Text = "COMPARE MATCH VALUE";
            // 
            // t_compare
            // 
            this.t_compare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.t_compare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_compare.ForeColor = System.Drawing.Color.Silver;
            this.t_compare.Location = new System.Drawing.Point(22, 375);
            this.t_compare.MaxLength = 100;
            this.t_compare.Name = "t_compare";
            this.t_compare.ReadOnly = true;
            this.t_compare.Size = new System.Drawing.Size(150, 32);
            this.t_compare.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Timer is calculated in CTC mode";
            // 
            // f_buttons
            // 
            this.f_buttons.Location = new System.Drawing.Point(12, 272);
            this.f_buttons.Name = "f_buttons";
            this.f_buttons.Size = new System.Drawing.Size(381, 65);
            this.f_buttons.TabIndex = 18;
            // 
            // p_clock
            // 
            this.p_clock.Image = ((System.Drawing.Image)(resources.GetObject("p_clock.Image")));
            this.p_clock.Location = new System.Drawing.Point(242, 47);
            this.p_clock.Name = "p_clock";
            this.p_clock.Size = new System.Drawing.Size(151, 134);
            this.p_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_clock.TabIndex = 19;
            this.p_clock.TabStop = false;
            // 
            // t_speed
            // 
            this.t_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.t_speed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_speed.ForeColor = System.Drawing.Color.Silver;
            this.t_speed.Location = new System.Drawing.Point(22, 205);
            this.t_speed.MaxLength = 100;
            this.t_speed.Name = "t_speed";
            this.t_speed.Size = new System.Drawing.Size(150, 32);
            this.t_speed.TabIndex = 7;
            this.t_speed.Text = "16000000";
            this.t_speed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_speed_KeyDown);
            // 
            // t_frequency
            // 
            this.t_frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.t_frequency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_frequency.ForeColor = System.Drawing.Color.Silver;
            this.t_frequency.Location = new System.Drawing.Point(22, 138);
            this.t_frequency.MaxLength = 100;
            this.t_frequency.Name = "t_frequency";
            this.t_frequency.Size = new System.Drawing.Size(150, 32);
            this.t_frequency.TabIndex = 6;
            this.t_frequency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_frequency_KeyDown);
            // 
            // t_time
            // 
            this.t_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.t_time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_time.ForeColor = System.Drawing.Color.Silver;
            this.t_time.Location = new System.Drawing.Point(22, 71);
            this.t_time.MaxLength = 100;
            this.t_time.Name = "t_time";
            this.t_time.Size = new System.Drawing.Size(150, 32);
            this.t_time.TabIndex = 5;
            this.t_time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_time_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(287, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "by Tristan Schneider";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(424, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_time);
            this.Controls.Add(this.t_frequency);
            this.Controls.Add(this.t_speed);
            this.Controls.Add(this.p_clock);
            this.Controls.Add(this.f_buttons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_compare);
            this.Controls.Add(this.l_compare);
            this.Controls.Add(this.l_hz1);
            this.Controls.Add(this.l_hz0);
            this.Controls.Add(this.l_s);
            this.Controls.Add(this.l_prescaler);
            this.Controls.Add(this.l_speed);
            this.Controls.Add(this.l_frequency);
            this.Controls.Add(this.l_time);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MaximumSize = new System.Drawing.Size(442, 470);
            this.MinimumSize = new System.Drawing.Size(442, 470);
            this.Name = "Form1";
            this.Text = "ATmega328 Timer Interrupt Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.p_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_frequency;
        private System.Windows.Forms.Label l_speed;
        private System.Windows.Forms.Label l_prescaler;
        private System.Windows.Forms.Label l_s;
        private System.Windows.Forms.Label l_hz0;
        private System.Windows.Forms.Label l_hz1;
        private System.Windows.Forms.Label l_compare;
        private System.Windows.Forms.TextBox t_compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel f_buttons;
        private System.Windows.Forms.PictureBox p_clock;
        private System.Windows.Forms.TextBox t_speed;
        private System.Windows.Forms.TextBox t_frequency;
        private System.Windows.Forms.TextBox t_time;
        private System.Windows.Forms.Label label2;
    }
}


﻿
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
            this.l_time = new System.Windows.Forms.Label();
            this.l_frequency = new System.Windows.Forms.Label();
            this.l_speed = new System.Windows.Forms.Label();
            this.l_prescaler = new System.Windows.Forms.Label();
            this.n_time = new System.Windows.Forms.NumericUpDown();
            this.n_frequency = new System.Windows.Forms.NumericUpDown();
            this.n_speed = new System.Windows.Forms.NumericUpDown();
            this.l_s = new System.Windows.Forms.Label();
            this.l_hz0 = new System.Windows.Forms.Label();
            this.l_hz1 = new System.Windows.Forms.Label();
            this.l_compare = new System.Windows.Forms.Label();
            this.t_compare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f_buttons = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.n_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_speed)).BeginInit();
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
            this.l_frequency.Location = new System.Drawing.Point(12, 126);
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
            this.l_speed.Location = new System.Drawing.Point(12, 206);
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
            this.l_prescaler.Location = new System.Drawing.Point(12, 290);
            this.l_prescaler.Name = "l_prescaler";
            this.l_prescaler.Size = new System.Drawing.Size(252, 21);
            this.l_prescaler.TabIndex = 3;
            this.l_prescaler.Text = "PRESCALER = { 1, 8, 64, 256, 1024 }";
            // 
            // n_time
            // 
            this.n_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_time.DecimalPlaces = 4;
            this.n_time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_time.ForeColor = System.Drawing.Color.Silver;
            this.n_time.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.n_time.Location = new System.Drawing.Point(21, 71);
            this.n_time.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.n_time.Name = "n_time";
            this.n_time.Size = new System.Drawing.Size(150, 32);
            this.n_time.TabIndex = 5;
            this.n_time.ValueChanged += new System.EventHandler(this.n_time_ValueChanged);
            // 
            // n_frequency
            // 
            this.n_frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_frequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_frequency.DecimalPlaces = 4;
            this.n_frequency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_frequency.ForeColor = System.Drawing.Color.Silver;
            this.n_frequency.Location = new System.Drawing.Point(21, 150);
            this.n_frequency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.n_frequency.Name = "n_frequency";
            this.n_frequency.Size = new System.Drawing.Size(150, 32);
            this.n_frequency.TabIndex = 6;
            this.n_frequency.ValueChanged += new System.EventHandler(this.n_frequency_ValueChanged);
            // 
            // n_speed
            // 
            this.n_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_speed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_speed.ForeColor = System.Drawing.Color.Silver;
            this.n_speed.Location = new System.Drawing.Point(21, 230);
            this.n_speed.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.n_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_speed.Name = "n_speed";
            this.n_speed.Size = new System.Drawing.Size(150, 32);
            this.n_speed.TabIndex = 7;
            this.n_speed.Value = new decimal(new int[] {
            16000000,
            0,
            0,
            0});
            this.n_speed.ValueChanged += new System.EventHandler(this.n_speed_ValueChanged);
            // 
            // l_s
            // 
            this.l_s.AutoSize = true;
            this.l_s.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_s.ForeColor = System.Drawing.Color.Silver;
            this.l_s.Location = new System.Drawing.Point(177, 82);
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
            this.l_hz0.Location = new System.Drawing.Point(177, 161);
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
            this.l_hz1.Location = new System.Drawing.Point(177, 241);
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
            this.l_compare.Location = new System.Drawing.Point(12, 405);
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
            this.t_compare.Location = new System.Drawing.Point(21, 429);
            this.t_compare.Name = "t_compare";
            this.t_compare.ReadOnly = true;
            this.t_compare.Size = new System.Drawing.Size(125, 32);
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
            this.f_buttons.Location = new System.Drawing.Point(21, 314);
            this.f_buttons.Name = "f_buttons";
            this.f_buttons.Size = new System.Drawing.Size(382, 74);
            this.f_buttons.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(418, 511);
            this.Controls.Add(this.f_buttons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_compare);
            this.Controls.Add(this.l_compare);
            this.Controls.Add(this.l_hz1);
            this.Controls.Add(this.l_hz0);
            this.Controls.Add(this.l_s);
            this.Controls.Add(this.n_speed);
            this.Controls.Add(this.n_frequency);
            this.Controls.Add(this.n_time);
            this.Controls.Add(this.l_prescaler);
            this.Controls.Add(this.l_speed);
            this.Controls.Add(this.l_frequency);
            this.Controls.Add(this.l_time);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form1";
            this.Text = "ATmega328 Timer Interrupt Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.n_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_frequency;
        private System.Windows.Forms.Label l_speed;
        private System.Windows.Forms.Label l_prescaler;
        private System.Windows.Forms.NumericUpDown n_time;
        private System.Windows.Forms.NumericUpDown n_frequency;
        private System.Windows.Forms.NumericUpDown n_speed;
        private System.Windows.Forms.Label l_s;
        private System.Windows.Forms.Label l_hz0;
        private System.Windows.Forms.Label l_hz1;
        private System.Windows.Forms.Label l_compare;
        private System.Windows.Forms.TextBox t_compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel f_buttons;
    }
}


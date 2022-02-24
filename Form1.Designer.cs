
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
            this.l_compare = new System.Windows.Forms.Label();
            this.n_time = new System.Windows.Forms.NumericUpDown();
            this.n_frequency = new System.Windows.Forms.NumericUpDown();
            this.n_speed = new System.Windows.Forms.NumericUpDown();
            this.n_prescaler = new System.Windows.Forms.NumericUpDown();
            this.n_compare = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_prescaler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_compare)).BeginInit();
            this.SuspendLayout();
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_time.ForeColor = System.Drawing.Color.Silver;
            this.l_time.Location = new System.Drawing.Point(12, 9);
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
            this.l_frequency.Location = new System.Drawing.Point(12, 88);
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
            this.l_speed.Location = new System.Drawing.Point(12, 168);
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
            this.l_prescaler.Location = new System.Drawing.Point(12, 252);
            this.l_prescaler.Name = "l_prescaler";
            this.l_prescaler.Size = new System.Drawing.Size(252, 21);
            this.l_prescaler.TabIndex = 3;
            this.l_prescaler.Text = "PRESCALER = { 1, 8, 64, 256, 1024 }";
            // 
            // l_compare
            // 
            this.l_compare.AutoSize = true;
            this.l_compare.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_compare.ForeColor = System.Drawing.Color.Silver;
            this.l_compare.Location = new System.Drawing.Point(12, 335);
            this.l_compare.Name = "l_compare";
            this.l_compare.Size = new System.Drawing.Size(205, 21);
            this.l_compare.TabIndex = 4;
            this.l_compare.Text = "COMPARE MATCH REGISTER";
            // 
            // n_time
            // 
            this.n_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_time.ForeColor = System.Drawing.Color.Silver;
            this.n_time.Location = new System.Drawing.Point(21, 33);
            this.n_time.Name = "n_time";
            this.n_time.Size = new System.Drawing.Size(150, 32);
            this.n_time.TabIndex = 5;
            this.n_time.ValueChanged += new System.EventHandler(this.n_time_ValueChanged);
            // 
            // n_frequency
            // 
            this.n_frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_frequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_frequency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_frequency.ForeColor = System.Drawing.Color.Silver;
            this.n_frequency.Location = new System.Drawing.Point(21, 112);
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
            this.n_speed.Location = new System.Drawing.Point(21, 192);
            this.n_speed.Maximum = new decimal(new int[] {
            20000000,
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
            // n_prescaler
            // 
            this.n_prescaler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_prescaler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_prescaler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_prescaler.ForeColor = System.Drawing.Color.Silver;
            this.n_prescaler.Location = new System.Drawing.Point(21, 276);
            this.n_prescaler.Name = "n_prescaler";
            this.n_prescaler.Size = new System.Drawing.Size(150, 32);
            this.n_prescaler.TabIndex = 8;
            this.n_prescaler.ValueChanged += new System.EventHandler(this.n_prescaler_ValueChanged);
            // 
            // n_compare
            // 
            this.n_compare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.n_compare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_compare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_compare.ForeColor = System.Drawing.Color.Silver;
            this.n_compare.Location = new System.Drawing.Point(21, 359);
            this.n_compare.Name = "n_compare";
            this.n_compare.Size = new System.Drawing.Size(150, 32);
            this.n_compare.TabIndex = 9;
            this.n_compare.ValueChanged += new System.EventHandler(this.n_compare_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(494, 568);
            this.Controls.Add(this.n_compare);
            this.Controls.Add(this.n_prescaler);
            this.Controls.Add(this.n_speed);
            this.Controls.Add(this.n_frequency);
            this.Controls.Add(this.n_time);
            this.Controls.Add(this.l_compare);
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
            ((System.ComponentModel.ISupportInitialize)(this.n_prescaler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_compare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_frequency;
        private System.Windows.Forms.Label l_speed;
        private System.Windows.Forms.Label l_prescaler;
        private System.Windows.Forms.Label l_compare;
        private System.Windows.Forms.NumericUpDown n_time;
        private System.Windows.Forms.NumericUpDown n_frequency;
        private System.Windows.Forms.NumericUpDown n_speed;
        private System.Windows.Forms.NumericUpDown n_prescaler;
        private System.Windows.Forms.NumericUpDown n_compare;
    }
}


namespace QuaySo
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStartSpin = new Button();
            lblTimerSet = new Label();
            label1 = new Label();
            lblSo2 = new Label();
            lblSo1 = new Label();
            lblSo3 = new Label();
            lblSo4 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStartSpin
            // 
            btnStartSpin.Location = new Point(381, 417);
            btnStartSpin.Name = "btnStartSpin";
            btnStartSpin.Size = new Size(75, 44);
            btnStartSpin.TabIndex = 17;
            btnStartSpin.Text = "Bắt đầu";
            btnStartSpin.UseVisualStyleBackColor = true;
            btnStartSpin.Click += btnStartSpin_Click;
            // 
            // lblTimerSet
            // 
            lblTimerSet.AutoSize = true;
            lblTimerSet.Location = new Point(424, 11);
            lblTimerSet.Name = "lblTimerSet";
            lblTimerSet.Size = new Size(51, 15);
            lblTimerSet.TabIndex = 16;
            lblTimerSet.Text = "lblTimer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 11);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 15;
            label1.Text = "Thời gian còn lại";
            // 
            // lblSo2
            // 
            lblSo2.BackColor = SystemColors.ActiveCaption;
            lblSo2.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo2.ForeColor = Color.Red;
            lblSo2.Location = new Point(218, 37);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(200, 377);
            lblSo2.TabIndex = 13;
            lblSo2.Text = "0";
            lblSo2.TextAlign = ContentAlignment.MiddleCenter;
            lblSo2.Click += lblSo2_Click;
            // 
            // lblSo1
            // 
            lblSo1.BackColor = SystemColors.ActiveCaption;
            lblSo1.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo1.ForeColor = Color.FromArgb(128, 255, 255);
            lblSo1.Location = new Point(12, 37);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(200, 377);
            lblSo1.TabIndex = 14;
            lblSo1.Text = "0";
            lblSo1.TextAlign = ContentAlignment.MiddleCenter;
            lblSo1.Click += lblSo1_Click_1;
            // 
            // lblSo3
            // 
            lblSo3.BackColor = SystemColors.ActiveCaption;
            lblSo3.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo3.ForeColor = Color.FromArgb(128, 128, 255);
            lblSo3.Location = new Point(424, 37);
            lblSo3.Name = "lblSo3";
            lblSo3.Size = new Size(200, 377);
            lblSo3.TabIndex = 13;
            lblSo3.Text = "0";
            lblSo3.TextAlign = ContentAlignment.MiddleCenter;
            lblSo3.Click += label2_Click;
            // 
            // lblSo4
            // 
            lblSo4.BackColor = SystemColors.ActiveCaption;
            lblSo4.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo4.ForeColor = Color.FromArgb(255, 255, 128);
            lblSo4.Location = new Point(630, 37);
            lblSo4.Name = "lblSo4";
            lblSo4.Size = new Size(200, 377);
            lblSo4.TabIndex = 13;
            lblSo4.Text = "0";
            lblSo4.TextAlign = ContentAlignment.MiddleCenter;
            lblSo4.Click += label3_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 473);
            Controls.Add(btnStartSpin);
            Controls.Add(lblTimerSet);
            Controls.Add(label1);
            Controls.Add(lblSo4);
            Controls.Add(lblSo3);
            Controls.Add(lblSo2);
            Controls.Add(lblSo1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartSpin;
        private Label lblTimerSet;
        private Label label1;
        private Label lblSo2;
        private Label lblSo1;
        private Label lblSo3;
        private Label lblSo4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
    }
}
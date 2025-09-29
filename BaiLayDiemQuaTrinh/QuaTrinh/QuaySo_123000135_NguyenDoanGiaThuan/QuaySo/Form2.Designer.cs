
namespace QuaySo
{
    partial class Form2
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
            lblSo3 = new Label();
            lblSo2 = new Label();
            lblSo1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblTimerSet = new Label();
            btnStartSpin = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSo3
            // 
            lblSo3.BackColor = SystemColors.ActiveCaption;
            lblSo3.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo3.ForeColor = Color.FromArgb(128, 128, 255);
            lblSo3.Location = new Point(534, 31);
            lblSo3.Name = "lblSo3";
            lblSo3.Size = new Size(254, 377);
            lblSo3.TabIndex = 1;
            lblSo3.Text = "0";
            lblSo3.TextAlign = ContentAlignment.MiddleCenter;
            lblSo3.Click += lblSo3_Click;
            // 
            // lblSo2
            // 
            lblSo2.BackColor = SystemColors.ActiveCaption;
            lblSo2.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo2.ForeColor = Color.Red;
            lblSo2.Location = new Point(272, 31);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(254, 377);
            lblSo2.TabIndex = 2;
            lblSo2.Text = "0";
            lblSo2.TextAlign = ContentAlignment.MiddleCenter;
            lblSo2.Click += lblSo2_Click;
            // 
            // lblSo1
            // 
            lblSo1.BackColor = SystemColors.ActiveCaption;
            lblSo1.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo1.ForeColor = Color.FromArgb(128, 255, 255);
            lblSo1.Location = new Point(12, 31);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(254, 377);
            lblSo1.TabIndex = 3;
            lblSo1.Text = "0";
            lblSo1.TextAlign = ContentAlignment.MiddleCenter;
            lblSo1.Click += lblSo1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Thời gian còn lại";
            // 
            // lblTimerSet
            // 
            lblTimerSet.AutoSize = true;
            lblTimerSet.Location = new Point(409, 9);
            lblTimerSet.Name = "lblTimerSet";
            lblTimerSet.Size = new Size(51, 15);
            lblTimerSet.TabIndex = 5;
            lblTimerSet.Text = "lblTimer";
            lblTimerSet.Click += lblTimerSet_Click;
            // 
            // btnStartSpin
            // 
            btnStartSpin.Location = new Point(360, 415);
            btnStartSpin.Name = "btnStartSpin";
            btnStartSpin.Size = new Size(75, 46);
            btnStartSpin.TabIndex = 6;
            btnStartSpin.Text = "Bắt đầu";
            btnStartSpin.UseVisualStyleBackColor = true;
            btnStartSpin.Click += btnStartSpin_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnStartSpin);
            Controls.Add(lblTimerSet);
            Controls.Add(label1);
            Controls.Add(lblSo3);
            Controls.Add(lblSo2);
            Controls.Add(lblSo1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblSo3;
        private Label lblSo2;
        private Label lblSo1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lblTimerSet;
        private Button btnStartSpin;
        private System.Windows.Forms.Timer timer2;
    }
}
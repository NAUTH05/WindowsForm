namespace QuaySo
{
    partial class Form3
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
            lblSo1 = new Label();
            btnStartSpin = new Button();
            lblSo2 = new Label();
            label1 = new Label();
            lblTimerSet = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSo1
            // 
            lblSo1.BackColor = SystemColors.ActiveCaption;
            lblSo1.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo1.ForeColor = Color.Cyan;
            lblSo1.Location = new Point(138, 37);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(254, 377);
            lblSo1.TabIndex = 9;
            lblSo1.Text = "0";
            lblSo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartSpin
            // 
            btnStartSpin.Location = new Point(359, 417);
            btnStartSpin.Name = "btnStartSpin";
            btnStartSpin.Size = new Size(75, 44);
            btnStartSpin.TabIndex = 12;
            btnStartSpin.Text = "Bắt đầu";
            btnStartSpin.UseVisualStyleBackColor = true;
            btnStartSpin.Click += btnStartSpin_Click;
            // 
            // lblSo2
            // 
            lblSo2.BackColor = SystemColors.ActiveCaption;
            lblSo2.Font = new Font("JetBrains Mono", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo2.ForeColor = Color.Red;
            lblSo2.Location = new Point(398, 37);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(254, 377);
            lblSo2.TabIndex = 8;
            lblSo2.Text = "0";
            lblSo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 11);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 10;
            label1.Text = "Thời gian còn lại";
            // 
            // lblTimerSet
            // 
            lblTimerSet.AutoSize = true;
            lblTimerSet.Location = new Point(409, 11);
            lblTimerSet.Name = "lblTimerSet";
            lblTimerSet.Size = new Size(51, 15);
            lblTimerSet.TabIndex = 11;
            lblTimerSet.Text = "lblTimer";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnStartSpin);
            Controls.Add(lblTimerSet);
            Controls.Add(label1);
            Controls.Add(lblSo2);
            Controls.Add(lblSo1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSo1;
        private Button btnStartSpin;
        private Label lblSo2;
        private Label label1;
        private Label lblTimerSet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
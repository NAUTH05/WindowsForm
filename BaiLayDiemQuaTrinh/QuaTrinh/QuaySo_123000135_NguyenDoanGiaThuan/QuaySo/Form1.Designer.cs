namespace QuaySo
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
            components = new System.ComponentModel.Container();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoLuong = new TextBox();
            txtTimerSet = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Thời gian:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(85, 22);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 23);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtTimerSet
            // 
            txtTimerSet.Location = new Point(85, 60);
            txtTimerSet.Name = "txtTimerSet";
            txtTimerSet.Size = new Size(100, 23);
            txtTimerSet.TabIndex = 3;
            txtTimerSet.TextChanged += txtTimerSet_TextChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(213, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 58);
            btnStart.TabIndex = 4;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 116);
            Controls.Add(btnStart);
            Controls.Add(txtTimerSet);
            Controls.Add(txtSoLuong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoLuong;
        private TextBox txtTimerSet;
        private Button btnStart;
    }
}

namespace RandomNumberWPoints
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
            label1 = new Label();
            label2 = new Label();
            CBbox_Level = new ComboBox();
            txtbox_SetNumber = new TextBox();
            Timer_Number = new System.Windows.Forms.Timer(components);
            lbl_TimerNumber = new Label();
            btn_Choose = new Button();
            btn_Start = new Button();
            txtbox_SoLanThang = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Cấp độ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Chọn số";
            // 
            // CBbox_Level
            // 
            CBbox_Level.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBbox_Level.FormattingEnabled = true;
            CBbox_Level.Items.AddRange(new object[] { "Easy", "Normal", "Hard", "BloodyHell" });
            CBbox_Level.Location = new Point(147, 38);
            CBbox_Level.Name = "CBbox_Level";
            CBbox_Level.Size = new Size(123, 24);
            CBbox_Level.TabIndex = 1;
            CBbox_Level.SelectedIndexChanged += CBbox_Level_SelectedIndexChanged;
            // 
            // txtbox_SetNumber
            // 
            txtbox_SetNumber.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_SetNumber.Location = new Point(147, 80);
            txtbox_SetNumber.Name = "txtbox_SetNumber";
            txtbox_SetNumber.Size = new Size(123, 23);
            txtbox_SetNumber.TabIndex = 2;
            txtbox_SetNumber.TextChanged += txtbox_SetNumber_TextChanged;
            // 
            // Timer_Number
            // 
            Timer_Number.Tick += Timer_Number_Tick;
            // 
            // lbl_TimerNumber
            // 
            lbl_TimerNumber.BorderStyle = BorderStyle.Fixed3D;
            lbl_TimerNumber.Font = new Font("JetBrains Mono", 100F);
            lbl_TimerNumber.Location = new Point(12, 119);
            lbl_TimerNumber.Name = "lbl_TimerNumber";
            lbl_TimerNumber.Size = new Size(276, 224);
            lbl_TimerNumber.TabIndex = 3;
            lbl_TimerNumber.Text = "0";
            lbl_TimerNumber.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TimerNumber.Click += lbl_TimerNumber_Click;
            // 
            // btn_Choose
            // 
            btn_Choose.Location = new Point(12, 355);
            btn_Choose.Name = "btn_Choose";
            btn_Choose.Size = new Size(131, 32);
            btn_Choose.TabIndex = 4;
            btn_Choose.Text = "Chọn";
            btn_Choose.UseVisualStyleBackColor = true;
            btn_Choose.Click += btn_Choose_Click;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(157, 355);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(131, 32);
            btn_Start.TabIndex = 4;
            btn_Start.Text = "Bắt đầu";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // txtbox_SoLanThang
            // 
            txtbox_SoLanThang.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_SoLanThang.Location = new Point(12, 402);
            txtbox_SoLanThang.Name = "txtbox_SoLanThang";
            txtbox_SoLanThang.Size = new Size(276, 33);
            txtbox_SoLanThang.TabIndex = 5;
            txtbox_SoLanThang.Text = "Số Lần Thắng: 0";
            txtbox_SoLanThang.TextChanged += txtbox_SoLanThang_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(txtbox_SoLanThang);
            Controls.Add(btn_Start);
            Controls.Add(btn_Choose);
            Controls.Add(lbl_TimerNumber);
            Controls.Add(txtbox_SetNumber);
            Controls.Add(CBbox_Level);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đỏ Đen Đê";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CBbox_Level;
        private TextBox txtbox_SetNumber;
        private System.Windows.Forms.Timer Timer_Number;
        private Label lbl_TimerNumber;
        private Button btn_Choose;
        private Button btn_Start;
        private TextBox txtbox_SoLanThang;
    }
}

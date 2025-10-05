namespace RandomNumber_N_Output
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
            txbox_MinNumber = new TextBox();
            txbox_MaxNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbox_OutPut = new TextBox();
            btn_Start = new Button();
            label3 = new Label();
            txbox_Times = new TextBox();
            btn_SortAZ = new Button();
            btnSortZA = new Button();
            SuspendLayout();
            // 
            // txbox_MinNumber
            // 
            txbox_MinNumber.Location = new Point(12, 26);
            txbox_MinNumber.Name = "txbox_MinNumber";
            txbox_MinNumber.Size = new Size(100, 23);
            txbox_MinNumber.TabIndex = 0;
            txbox_MinNumber.TextChanged += txbox_MinNumber_TextChanged;
            // 
            // txbox_MaxNumber
            // 
            txbox_MaxNumber.Location = new Point(118, 26);
            txbox_MaxNumber.Name = "txbox_MaxNumber";
            txbox_MaxNumber.Size = new Size(100, 23);
            txbox_MaxNumber.TabIndex = 0;
            txbox_MaxNumber.TextChanged += txbox_MaxNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 8);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Số Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 8);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Số Max";
            // 
            // txbox_OutPut
            // 
            txbox_OutPut.AcceptsReturn = true;
            txbox_OutPut.BorderStyle = BorderStyle.FixedSingle;
            txbox_OutPut.Location = new Point(12, 62);
            txbox_OutPut.Multiline = true;
            txbox_OutPut.Name = "txbox_OutPut";
            txbox_OutPut.Size = new Size(407, 302);
            txbox_OutPut.TabIndex = 2;
            txbox_OutPut.TextChanged += txbox_OutPut_TextChanged;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(330, 16);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(96, 40);
            btn_Start.TabIndex = 3;
            btn_Start.Text = "Bắt đầu";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 8);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Số Lượng";
            // 
            // txbox_Times
            // 
            txbox_Times.Location = new Point(224, 26);
            txbox_Times.Name = "txbox_Times";
            txbox_Times.Size = new Size(100, 23);
            txbox_Times.TabIndex = 4;
            txbox_Times.TextChanged += txbox_Times_TextChanged;
            // 
            // btn_SortAZ
            // 
            btn_SortAZ.Location = new Point(12, 389);
            btn_SortAZ.Name = "btn_SortAZ";
            btn_SortAZ.Size = new Size(104, 23);
            btn_SortAZ.TabIndex = 5;
            btn_SortAZ.Text = "Sắp xếp A-Z";
            btn_SortAZ.UseVisualStyleBackColor = true;
            btn_SortAZ.Click += btn_SortAZ_Click;
            // 
            // btnSortZA
            // 
            btnSortZA.Location = new Point(143, 389);
            btnSortZA.Name = "btnSortZA";
            btnSortZA.Size = new Size(104, 23);
            btnSortZA.TabIndex = 6;
            btnSortZA.Text = "Sắp xếp Z-A";
            btnSortZA.UseVisualStyleBackColor = true;
            btnSortZA.Click += btnSortZA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(btnSortZA);
            Controls.Add(btn_SortAZ);
            Controls.Add(txbox_Times);
            Controls.Add(btn_Start);
            Controls.Add(txbox_OutPut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbox_MaxNumber);
            Controls.Add(txbox_MinNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txbox_MinNumber;
        private TextBox txbox_MaxNumber;
        private Label label1;
        private Label label2;
        private TextBox txbox_OutPut;
        private Button btn_Start;
        private Label label3;
        private TextBox txbox_Times;
        private Button btn_SortAZ;
        private Button btnSortZA;
    }
}

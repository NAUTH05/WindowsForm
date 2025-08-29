namespace Caculator
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
            label1 = new Label();
            label2 = new Label();
            lblKetQua = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label4 = new Label();
            CbxPhepTinh = new ComboBox();
            label5 = new Label();
            btnCaculate = new Button();
            btnClear = new Button();
            lblNoitce = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Number 2";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(363, 32);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(45, 19);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "label3";
            lblKetQua.Visible = false;
            lblKetQua.Click += lblKetQua_Click;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(12, 29);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(100, 23);
            txtNumber1.TabIndex = 2;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(224, 29);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(100, 23);
            txtNumber2.TabIndex = 3;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 9);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Phép Tính";
            // 
            // CbxPhepTinh
            // 
            CbxPhepTinh.FormattingEnabled = true;
            CbxPhepTinh.Items.AddRange(new object[] { "+", "-", "x", "/", "^" });
            CbxPhepTinh.Location = new Point(118, 29);
            CbxPhepTinh.Name = "CbxPhepTinh";
            CbxPhepTinh.Size = new Size(100, 23);
            CbxPhepTinh.TabIndex = 4;
            CbxPhepTinh.SelectedIndexChanged += CbxPhepTinh_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(330, 22);
            label5.Name = "label5";
            label5.Size = new Size(27, 30);
            label5.TabIndex = 1;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(214, 326);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(75, 23);
            btnCaculate.TabIndex = 5;
            btnCaculate.Text = "Tính";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(295, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblNoitce
            // 
            lblNoitce.AutoSize = true;
            lblNoitce.ForeColor = Color.Red;
            lblNoitce.Location = new Point(12, 70);
            lblNoitce.Name = "lblNoitce";
            lblNoitce.Size = new Size(42, 15);
            lblNoitce.TabIndex = 6;
            lblNoitce.Text = "Noitce";
            lblNoitce.Visible = false;
            lblNoitce.Click += lblNoitce_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(lblNoitce);
            Controls.Add(btnClear);
            Controls.Add(btnCaculate);
            Controls.Add(CbxPhepTinh);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblKetQua);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblKetQua;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label4;
        private ComboBox CbxPhepTinh;
        private Label label5;
        private Button btnCaculate;
        private Button btnClear;
        private Label lblNoitce;
    }
}

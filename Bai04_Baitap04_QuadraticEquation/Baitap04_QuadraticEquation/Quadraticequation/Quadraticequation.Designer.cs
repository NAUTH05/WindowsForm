namespace Quadraticequation
{
    partial class Quadraticequation
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblNoitce = new Label();
            txtDelta = new Label();
            lblX1 = new Label();
            lblPhuongTrinh = new Label();
            label9 = new Label();
            label10 = new Label();
            lblKetQua = new Label();
            lblX2 = new Label();
            btnCaculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(62, 69);
            txtA.Name = "txtA";
            txtA.Size = new Size(54, 23);
            txtA.TabIndex = 0;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(210, 69);
            txtB.Name = "txtB";
            txtB.Size = new Size(54, 23);
            txtB.TabIndex = 0;
            txtB.TextChanged += textBox2_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(358, 69);
            txtC.Name = "txtC";
            txtC.Size = new Size(54, 23);
            txtC.TabIndex = 0;
            txtC.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 73);
            label1.Name = "label1";
            label1.Size = new Size(14, 16);
            label1.TabIndex = 1;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 73);
            label2.Name = "label2";
            label2.Size = new Size(14, 16);
            label2.TabIndex = 1;
            label2.Text = "=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 73);
            label4.Name = "label4";
            label4.Size = new Size(14, 16);
            label4.TabIndex = 1;
            label4.Text = "x";
            // 
            // lblNoitce
            // 
            lblNoitce.AutoSize = true;
            lblNoitce.Location = new Point(62, 124);
            lblNoitce.Name = "lblNoitce";
            lblNoitce.Size = new Size(70, 16);
            lblNoitce.TabIndex = 1;
            lblNoitce.Text = "lblNoitce";
            lblNoitce.Visible = false;
            lblNoitce.Click += lblNoitce_Click;
            // 
            // txtDelta
            // 
            txtDelta.AutoSize = true;
            txtDelta.Location = new Point(62, 195);
            txtDelta.Name = "txtDelta";
            txtDelta.Size = new Size(63, 16);
            txtDelta.TabIndex = 1;
            txtDelta.Text = "txtDelta";
            txtDelta.Visible = false;
            txtDelta.Click += txtDelta_Click;
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Location = new Point(62, 277);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(42, 16);
            lblX1.TabIndex = 1;
            lblX1.Text = "lblX1";
            lblX1.Visible = false;
            lblX1.Click += label7_Click;
            // 
            // lblPhuongTrinh
            // 
            lblPhuongTrinh.AutoSize = true;
            lblPhuongTrinh.Location = new Point(62, 236);
            lblPhuongTrinh.Name = "lblPhuongTrinh";
            lblPhuongTrinh.Size = new Size(105, 16);
            lblPhuongTrinh.TabIndex = 1;
            lblPhuongTrinh.Text = "lblPhuongTrinh";
            lblPhuongTrinh.Visible = false;
            lblPhuongTrinh.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(122, 73);
            label9.Name = "label9";
            label9.Size = new Size(21, 16);
            label9.TabIndex = 1;
            label9.Text = "x2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 73);
            label10.Name = "label10";
            label10.Size = new Size(14, 16);
            label10.TabIndex = 1;
            label10.Text = "+";
            label10.Click += label10_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(449, 73);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(14, 16);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "0";
            lblKetQua.Click += lblKetQua_Click;
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(62, 309);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(42, 16);
            lblX2.TabIndex = 1;
            lblX2.Text = "lblX2";
            lblX2.Visible = false;
            lblX2.Click += label7_Click;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(62, 154);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(87, 25);
            btnCaculate.TabIndex = 2;
            btnCaculate.Text = "Tính";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(155, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 25);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Quadraticequation
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 480);
            Controls.Add(btnClear);
            Controls.Add(btnCaculate);
            Controls.Add(lblKetQua);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(lblPhuongTrinh);
            Controls.Add(lblX2);
            Controls.Add(lblX1);
            Controls.Add(txtDelta);
            Controls.Add(lblNoitce);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Quadraticequation";
            Text = "QuadraticEquation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label lblNoitce;
        private Label txtDelta;
        private Label lblX1;
        private Label lblPhuongTrinh;
        private Label label9;
        private Label label10;
        private Label lblKetQua;
        private Label lblX2;
        private Button btnCaculate;
        private Button btnClear;
    }
}

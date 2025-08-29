namespace ChangeCaption
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
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.WarningLB = new System.Windows.Forms.Label();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 12);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(555, 27);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(251, 230);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(75, 28);
            this.ChangeBTN.TabIndex = 1;
            this.ChangeBTN.Text = "Change";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // WarningLB
            // 
            this.WarningLB.AutoSize = true;
            this.WarningLB.ForeColor = System.Drawing.Color.Red;
            this.WarningLB.Location = new System.Drawing.Point(18, 43);
            this.WarningLB.Name = "WarningLB";
            this.WarningLB.Size = new System.Drawing.Size(42, 20);
            this.WarningLB.TabIndex = 2;
            this.WarningLB.Text = "label";
            this.WarningLB.Visible = false;
            this.WarningLB.Click += new System.EventHandler(this.WarningLB_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(251, 264);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 34);
            this.ClearBTN.TabIndex = 3;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 299);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.WarningLB);
            this.Controls.Add(this.ChangeBTN);
            this.Controls.Add(this.TxtBox);
            this.Name = "Form1";
            this.Text = "CHANGE-CAPTION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBox;
        private Button ChangeBTN;
        private Label WarningLB;
        private Button ClearBTN;
    }
}
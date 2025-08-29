namespace LUCKY_SEVEN
{
    partial class Form1
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
            this.SPIN = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.t = new System.Diagnostics.EventLog();
            this.THONGBAO = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.t)).BeginInit();
            this.SuspendLayout();
            // 
            // SPIN
            // 
            this.SPIN.Location = new System.Drawing.Point(12, 12);
            this.SPIN.Name = "SPIN";
            this.SPIN.Size = new System.Drawing.Size(75, 23);
            this.SPIN.TabIndex = 0;
            this.SPIN.Text = "SPIN";
            this.SPIN.UseVisualStyleBackColor = true;
            this.SPIN.Click += new System.EventHandler(this.SPIN_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(12, 41);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 1;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(12, 70);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 23);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // t
            // 
            this.t.SynchronizingObject = this;
            // 
            // THONGBAO
            // 
            this.THONGBAO.Location = new System.Drawing.Point(12, 199);
            this.THONGBAO.Multiline = true;
            this.THONGBAO.Name = "THONGBAO";
            this.THONGBAO.Size = new System.Drawing.Size(225, 96);
            this.THONGBAO.TabIndex = 3;
            this.THONGBAO.TextChanged += new System.EventHandler(this.THONGBAO_TextChanged);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(283, 90);
            this.Num1.Multiline = true;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(149, 107);
            this.Num1.TabIndex = 4;
            this.Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(438, 90);
            this.Num2.Multiline = true;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(149, 107);
            this.Num2.TabIndex = 7;
            this.Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(593, 90);
            this.Num3.Multiline = true;
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(149, 107);
            this.Num3.TabIndex = 8;
            this.Num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.THONGBAO);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.SPIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SPIN;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button EXIT;
        private System.Diagnostics.EventLog t;
        private System.Windows.Forms.TextBox THONGBAO;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num3;
        private System.Windows.Forms.TextBox Num2;
    }
}


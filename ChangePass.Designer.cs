namespace CRUDOP2
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parolaNouaTxt = new System.Windows.Forms.TextBox();
            this.cnpTxt = new System.Windows.Forms.TextBox();
            this.savenewpass = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "PAROLA NOUA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 35);
            this.label5.TabIndex = 34;
            this.label5.Text = "CNP";
            // 
            // parolaNouaTxt
            // 
            this.parolaNouaTxt.Location = new System.Drawing.Point(287, 223);
            this.parolaNouaTxt.Name = "parolaNouaTxt";
            this.parolaNouaTxt.PasswordChar = '*';
            this.parolaNouaTxt.Size = new System.Drawing.Size(254, 22);
            this.parolaNouaTxt.TabIndex = 33;
            // 
            // cnpTxt
            // 
            this.cnpTxt.Location = new System.Drawing.Point(287, 126);
            this.cnpTxt.Name = "cnpTxt";
            this.cnpTxt.Size = new System.Drawing.Size(254, 22);
            this.cnpTxt.TabIndex = 32;
            // 
            // savenewpass
            // 
            this.savenewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.savenewpass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savenewpass.Location = new System.Drawing.Point(159, 327);
            this.savenewpass.Name = "savenewpass";
            this.savenewpass.Size = new System.Drawing.Size(267, 71);
            this.savenewpass.TabIndex = 36;
            this.savenewpass.Text = "SALVEAZA";
            this.savenewpass.UseVisualStyleBackColor = false;
            this.savenewpass.Click += new System.EventHandler(this.savenewpass_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(428, 455);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(157, 61);
            this.cancel.TabIndex = 37;
            this.cancel.Text = "RENUNTA";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(609, 528);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.savenewpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parolaNouaTxt);
            this.Controls.Add(this.cnpTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parolaNouaTxt;
        private System.Windows.Forms.TextBox cnpTxt;
        private System.Windows.Forms.Button savenewpass;
        private System.Windows.Forms.Button cancel;
    }
}
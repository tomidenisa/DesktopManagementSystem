namespace CRUDOP2
{
    partial class NotificationEmpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationEmpl));
            this.button1 = new System.Windows.Forms.Button();
            this.LOGIN = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(368, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 71);
            this.button1.TabIndex = 56;
            this.button1.Text = "INAPOI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.LOGIN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(964, 194);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(267, 71);
            this.LOGIN.TabIndex = 55;
            this.LOGIN.Text = "INCARCA NOTIFICARI";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(637, 298);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(920, 610);
            this.rtbMessages.TabIndex = 54;
            this.rtbMessages.Text = "";
            // 
            // NotificationEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.rtbMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotificationEmpl";
            this.Text = "NotificationEmpl";
            this.Load += new System.EventHandler(this.NotificationEmpl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}
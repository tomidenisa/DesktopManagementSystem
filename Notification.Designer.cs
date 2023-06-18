namespace CRUDOP2
{
    partial class Notification
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
            this.notifications = new System.Windows.Forms.DataGridView();
            this.AddCantitate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notifications)).BeginInit();
            this.SuspendLayout();
            // 
            // notifications
            // 
            this.notifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifications.Location = new System.Drawing.Point(218, 159);
            this.notifications.Name = "notifications";
            this.notifications.RowHeadersWidth = 51;
            this.notifications.RowTemplate.Height = 24;
            this.notifications.Size = new System.Drawing.Size(1120, 593);
            this.notifications.TabIndex = 0;
            // 
            // AddCantitate
            // 
            this.AddCantitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.AddCantitate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCantitate.Location = new System.Drawing.Point(428, 34);
            this.AddCantitate.Name = "AddCantitate";
            this.AddCantitate.Size = new System.Drawing.Size(455, 59);
            this.AddCantitate.TabIndex = 50;
            this.AddCantitate.Text = "Navigheaza la notificari";
            this.AddCantitate.UseVisualStyleBackColor = false;
            this.AddCantitate.Click += new System.EventHandler(this.AddCantitate_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1488, 957);
            this.Controls.Add(this.AddCantitate);
            this.Controls.Add(this.notifications);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView notifications;
        private System.Windows.Forms.Button AddCantitate;
    }
}
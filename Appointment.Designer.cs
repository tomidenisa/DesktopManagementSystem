namespace CRUDOP2
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.OfferButton = new System.Windows.Forms.Button();
            this.DevizButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.flowLayoutPanel1.Controls.Add(this.Logo);
            this.flowLayoutPanel1.Controls.Add(this.homebutton);
            this.flowLayoutPanel1.Controls.Add(this.ProgramButton);
            this.flowLayoutPanel1.Controls.Add(this.ProductButton);
            this.flowLayoutPanel1.Controls.Add(this.OfferButton);
            this.flowLayoutPanel1.Controls.Add(this.DevizButton);
            this.flowLayoutPanel1.Controls.Add(this.AdminButton);
            this.flowLayoutPanel1.Controls.Add(this.LogoutButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 1010);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(355, 333);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // homebutton
            // 
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Image = global::CRUDOP2.Properties.Resources.cr1;
            this.homebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebutton.Location = new System.Drawing.Point(3, 409);
            this.homebutton.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.homebutton.Name = "homebutton";
            this.homebutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.homebutton.Size = new System.Drawing.Size(425, 57);
            this.homebutton.TabIndex = 2;
            this.homebutton.Text = "        Acasa";
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // ProgramButton
            // 
            this.ProgramButton.FlatAppearance.BorderSize = 0;
            this.ProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramButton.Image = global::CRUDOP2.Properties.Resources.programari_removebg_preview;
            this.ProgramButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramButton.Location = new System.Drawing.Point(3, 472);
            this.ProgramButton.Name = "ProgramButton";
            this.ProgramButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ProgramButton.Size = new System.Drawing.Size(395, 56);
            this.ProgramButton.TabIndex = 3;
            this.ProgramButton.Text = "        Programare";
            this.ProgramButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramButton.UseVisualStyleBackColor = true;
            this.ProgramButton.Click += new System.EventHandler(this.ProgramButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.Image = global::CRUDOP2.Properties.Resources.produse_removebg_preview;
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(3, 534);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ProductButton.Size = new System.Drawing.Size(409, 58);
            this.ProductButton.TabIndex = 4;
            this.ProductButton.Text = "        Produse";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // OfferButton
            // 
            this.OfferButton.FlatAppearance.BorderSize = 0;
            this.OfferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfferButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferButton.Image = global::CRUDOP2.Properties.Resources.ofertare_removebg_preview;
            this.OfferButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OfferButton.Location = new System.Drawing.Point(3, 598);
            this.OfferButton.Name = "OfferButton";
            this.OfferButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.OfferButton.Size = new System.Drawing.Size(430, 66);
            this.OfferButton.TabIndex = 5;
            this.OfferButton.Text = "        Ofertare";
            this.OfferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OfferButton.UseVisualStyleBackColor = true;
            this.OfferButton.Click += new System.EventHandler(this.OfferButton_Click);
            // 
            // DevizButton
            // 
            this.DevizButton.FlatAppearance.BorderSize = 0;
            this.DevizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevizButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevizButton.Image = global::CRUDOP2.Properties.Resources.deviz_removebg_preview;
            this.DevizButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DevizButton.Location = new System.Drawing.Point(3, 670);
            this.DevizButton.Name = "DevizButton";
            this.DevizButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DevizButton.Size = new System.Drawing.Size(409, 63);
            this.DevizButton.TabIndex = 6;
            this.DevizButton.Text = "        Deviz";
            this.DevizButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DevizButton.UseVisualStyleBackColor = true;
            this.DevizButton.Click += new System.EventHandler(this.DevizButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Image = global::CRUDOP2.Properties.Resources.administrare_removebg_preview;
            this.AdminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButton.Location = new System.Drawing.Point(3, 739);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AdminButton.Size = new System.Drawing.Size(409, 61);
            this.AdminButton.TabIndex = 7;
            this.AdminButton.Text = "       Administrare";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Image = global::CRUDOP2.Properties.Resources.Design_fără_titlu;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(3, 903);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LogoutButton.Size = new System.Drawing.Size(358, 68);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "       Iesire";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 1010);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button OfferButton;
        private System.Windows.Forms.Button DevizButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}
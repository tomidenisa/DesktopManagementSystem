namespace CRUDOP2
{
    partial class CatalogServRep
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogServRep));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.OfferButton = new System.Windows.Forms.Button();
            this.DevizButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dataGridViewTipContact = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.catalogserviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceAutoDBDataSet = new CRUDOP2.ServiceAutoDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catalogtipreparatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalog_serviciiTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.catalog_serviciiTableAdapter();
            this.catalog_tip_reparatieTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.catalog_tip_reparatieTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpnecesarmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpnecesarminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idcatalogserviciiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ServDenumireTxt = new System.Windows.Forms.TextBox();
            this.ServDescriereTxt = new System.Windows.Forms.TextBox();
            this.ServDiscountTxt = new System.Windows.Forms.TextBox();
            this.ServActiv = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReparActiv = new System.Windows.Forms.CheckBox();
            this.ReparPret = new System.Windows.Forms.TextBox();
            this.ReparMinTimp = new System.Windows.Forms.TextBox();
            this.ReparMaxTimp = new System.Windows.Forms.TextBox();
            this.ReparDescriere = new System.Windows.Forms.TextBox();
            this.AddServ = new System.Windows.Forms.Button();
            this.DeleteServ = new System.Windows.Forms.Button();
            this.CancelServ = new System.Windows.Forms.Button();
            this.SearchServ = new System.Windows.Forms.TextBox();
            this.SearchBtnServ = new System.Windows.Forms.Button();
            this.AddRepar = new System.Windows.Forms.Button();
            this.DeleteRepar = new System.Windows.Forms.Button();
            this.CancelRepar = new System.Windows.Forms.Button();
            this.SearchBtnRepar = new System.Windows.Forms.Button();
            this.SearchRepar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogserviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogtipreparatieBindingSource)).BeginInit();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 1055);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dataGridViewTipContact
            // 
            this.dataGridViewTipContact.AutoGenerateColumns = false;
            this.dataGridViewTipContact.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewTipContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.activDataGridViewCheckBoxColumn});
            this.dataGridViewTipContact.DataSource = this.catalogserviciiBindingSource;
            this.dataGridViewTipContact.Location = new System.Drawing.Point(1022, 104);
            this.dataGridViewTipContact.Name = "dataGridViewTipContact";
            this.dataGridViewTipContact.RowHeadersWidth = 51;
            this.dataGridViewTipContact.RowTemplate.Height = 24;
            this.dataGridViewTipContact.Size = new System.Drawing.Size(668, 362);
            this.dataGridViewTipContact.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // activDataGridViewCheckBoxColumn
            // 
            this.activDataGridViewCheckBoxColumn.DataPropertyName = "activ";
            this.activDataGridViewCheckBoxColumn.HeaderText = "Activ";
            this.activDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activDataGridViewCheckBoxColumn.Name = "activDataGridViewCheckBoxColumn";
            this.activDataGridViewCheckBoxColumn.Width = 125;
            // 
            // catalogserviciiBindingSource
            // 
            this.catalogserviciiBindingSource.DataMember = "catalog_servicii";
            this.catalogserviciiBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // serviceAutoDBDataSet
            // 
            this.serviceAutoDBDataSet.DataSetName = "ServiceAutoDBDataSet";
            this.serviceAutoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.denumireDataGridViewTextBoxColumn1,
            this.descriereDataGridViewTextBoxColumn1,
            this.timpnecesarmaxDataGridViewTextBoxColumn,
            this.timpnecesarminDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.activDataGridViewCheckBoxColumn1,
            this.idcatalogserviciiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogtipreparatieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1022, 570);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 461);
            this.dataGridView1.TabIndex = 10;
            // 
            // catalogtipreparatieBindingSource
            // 
            this.catalogtipreparatieBindingSource.DataMember = "catalog_tip_reparatie";
            this.catalogtipreparatieBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // catalog_serviciiTableAdapter
            // 
            this.catalog_serviciiTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_tip_reparatieTableAdapter
            // 
            this.catalog_tip_reparatieTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CRUDOP2.Properties.Resources.deviz_removebg_preview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1022, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(425, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "        Catalog Servicii";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CRUDOP2.Properties.Resources.deviz_removebg_preview;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1022, 493);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(425, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "        Catalog Tip Reparatii";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // denumireDataGridViewTextBoxColumn1
            // 
            this.denumireDataGridViewTextBoxColumn1.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn1.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn1.Name = "denumireDataGridViewTextBoxColumn1";
            this.denumireDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn1
            // 
            this.descriereDataGridViewTextBoxColumn1.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn1.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn1.Name = "descriereDataGridViewTextBoxColumn1";
            this.descriereDataGridViewTextBoxColumn1.Width = 125;
            // 
            // timpnecesarmaxDataGridViewTextBoxColumn
            // 
            this.timpnecesarmaxDataGridViewTextBoxColumn.DataPropertyName = "timp_necesar_max";
            this.timpnecesarmaxDataGridViewTextBoxColumn.HeaderText = "Timp Maxim Necesar";
            this.timpnecesarmaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timpnecesarmaxDataGridViewTextBoxColumn.Name = "timpnecesarmaxDataGridViewTextBoxColumn";
            this.timpnecesarmaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // timpnecesarminDataGridViewTextBoxColumn
            // 
            this.timpnecesarminDataGridViewTextBoxColumn.DataPropertyName = "timp_necesar_min";
            this.timpnecesarminDataGridViewTextBoxColumn.HeaderText = "Timp Minim Necesar";
            this.timpnecesarminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timpnecesarminDataGridViewTextBoxColumn.Name = "timpnecesarminDataGridViewTextBoxColumn";
            this.timpnecesarminDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // activDataGridViewCheckBoxColumn1
            // 
            this.activDataGridViewCheckBoxColumn1.DataPropertyName = "activ";
            this.activDataGridViewCheckBoxColumn1.HeaderText = "Activ";
            this.activDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.activDataGridViewCheckBoxColumn1.Name = "activDataGridViewCheckBoxColumn1";
            this.activDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // idcatalogserviciiDataGridViewTextBoxColumn
            // 
            this.idcatalogserviciiDataGridViewTextBoxColumn.DataPropertyName = "id_catalog_servicii";
            this.idcatalogserviciiDataGridViewTextBoxColumn.HeaderText = "ID Catalog Servicii";
            this.idcatalogserviciiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcatalogserviciiDataGridViewTextBoxColumn.Name = "idcatalogserviciiDataGridViewTextBoxColumn";
            this.idcatalogserviciiDataGridViewTextBoxColumn.Width = 125;
            // 
            // PosName
            // 
            this.PosName.AutoSize = true;
            this.PosName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosName.Location = new System.Drawing.Point(456, 826);
            this.PosName.Name = "PosName";
            this.PosName.Size = new System.Drawing.Size(50, 20);
            this.PosName.TabIndex = 24;
            this.PosName.Text = "Activ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 780);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Timp Minim Necesar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Timp Maxim Necesar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descriere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Denumire ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Descriere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Denumire ";
            // 
            // ServDenumireTxt
            // 
            this.ServDenumireTxt.Location = new System.Drawing.Point(597, 104);
            this.ServDenumireTxt.Name = "ServDenumireTxt";
            this.ServDenumireTxt.Size = new System.Drawing.Size(169, 22);
            this.ServDenumireTxt.TabIndex = 34;
            // 
            // ServDescriereTxt
            // 
            this.ServDescriereTxt.Location = new System.Drawing.Point(597, 146);
            this.ServDescriereTxt.Name = "ServDescriereTxt";
            this.ServDescriereTxt.Size = new System.Drawing.Size(169, 22);
            this.ServDescriereTxt.TabIndex = 35;
            // 
            // ServDiscountTxt
            // 
            this.ServDiscountTxt.Location = new System.Drawing.Point(597, 201);
            this.ServDiscountTxt.Name = "ServDiscountTxt";
            this.ServDiscountTxt.Size = new System.Drawing.Size(169, 22);
            this.ServDiscountTxt.TabIndex = 36;
            // 
            // ServActiv
            // 
            this.ServActiv.AutoSize = true;
            this.ServActiv.Location = new System.Drawing.Point(597, 256);
            this.ServActiv.Name = "ServActiv";
            this.ServActiv.Size = new System.Drawing.Size(18, 17);
            this.ServActiv.TabIndex = 37;
            this.ServActiv.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(646, 570);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Activ";
            // 
            // ReparActiv
            // 
            this.ReparActiv.AutoSize = true;
            this.ReparActiv.Location = new System.Drawing.Point(646, 826);
            this.ReparActiv.Name = "ReparActiv";
            this.ReparActiv.Size = new System.Drawing.Size(18, 17);
            this.ReparActiv.TabIndex = 40;
            this.ReparActiv.UseVisualStyleBackColor = true;
            // 
            // ReparPret
            // 
            this.ReparPret.Location = new System.Drawing.Point(646, 780);
            this.ReparPret.Name = "ReparPret";
            this.ReparPret.Size = new System.Drawing.Size(169, 22);
            this.ReparPret.TabIndex = 41;
            // 
            // ReparMinTimp
            // 
            this.ReparMinTimp.Location = new System.Drawing.Point(646, 729);
            this.ReparMinTimp.Name = "ReparMinTimp";
            this.ReparMinTimp.Size = new System.Drawing.Size(169, 22);
            this.ReparMinTimp.TabIndex = 42;
            // 
            // ReparMaxTimp
            // 
            this.ReparMaxTimp.Location = new System.Drawing.Point(646, 680);
            this.ReparMaxTimp.Name = "ReparMaxTimp";
            this.ReparMaxTimp.Size = new System.Drawing.Size(169, 22);
            this.ReparMaxTimp.TabIndex = 43;
            // 
            // ReparDescriere
            // 
            this.ReparDescriere.Location = new System.Drawing.Point(646, 625);
            this.ReparDescriere.Name = "ReparDescriere";
            this.ReparDescriere.Size = new System.Drawing.Size(169, 22);
            this.ReparDescriere.TabIndex = 44;
            // 
            // AddServ
            // 
            this.AddServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.AddServ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServ.Location = new System.Drawing.Point(460, 319);
            this.AddServ.Name = "AddServ";
            this.AddServ.Size = new System.Drawing.Size(134, 36);
            this.AddServ.TabIndex = 45;
            this.AddServ.Text = "Salveaza";
            this.AddServ.UseVisualStyleBackColor = false;
            // 
            // DeleteServ
            // 
            this.DeleteServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.DeleteServ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteServ.Location = new System.Drawing.Point(620, 319);
            this.DeleteServ.Name = "DeleteServ";
            this.DeleteServ.Size = new System.Drawing.Size(111, 36);
            this.DeleteServ.TabIndex = 46;
            this.DeleteServ.Text = "Sterge";
            this.DeleteServ.UseVisualStyleBackColor = false;
            // 
            // CancelServ
            // 
            this.CancelServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.CancelServ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelServ.Location = new System.Drawing.Point(766, 319);
            this.CancelServ.Name = "CancelServ";
            this.CancelServ.Size = new System.Drawing.Size(125, 36);
            this.CancelServ.TabIndex = 47;
            this.CancelServ.Text = "Renunta";
            this.CancelServ.UseVisualStyleBackColor = false;
            // 
            // SearchServ
            // 
            this.SearchServ.Location = new System.Drawing.Point(460, 385);
            this.SearchServ.Name = "SearchServ";
            this.SearchServ.Size = new System.Drawing.Size(431, 22);
            this.SearchServ.TabIndex = 48;
            // 
            // SearchBtnServ
            // 
            this.SearchBtnServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.SearchBtnServ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnServ.Location = new System.Drawing.Point(521, 421);
            this.SearchBtnServ.Name = "SearchBtnServ";
            this.SearchBtnServ.Size = new System.Drawing.Size(333, 41);
            this.SearchBtnServ.TabIndex = 49;
            this.SearchBtnServ.Text = "Cauta serviciul dupa denumire";
            this.SearchBtnServ.UseVisualStyleBackColor = false;
            // 
            // AddRepar
            // 
            this.AddRepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.AddRepar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRepar.Location = new System.Drawing.Point(460, 869);
            this.AddRepar.Name = "AddRepar";
            this.AddRepar.Size = new System.Drawing.Size(134, 36);
            this.AddRepar.TabIndex = 50;
            this.AddRepar.Text = "Salveaza";
            this.AddRepar.UseVisualStyleBackColor = false;
            // 
            // DeleteRepar
            // 
            this.DeleteRepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.DeleteRepar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRepar.Location = new System.Drawing.Point(635, 869);
            this.DeleteRepar.Name = "DeleteRepar";
            this.DeleteRepar.Size = new System.Drawing.Size(111, 36);
            this.DeleteRepar.TabIndex = 51;
            this.DeleteRepar.Text = "Sterge";
            this.DeleteRepar.UseVisualStyleBackColor = false;
            // 
            // CancelRepar
            // 
            this.CancelRepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.CancelRepar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRepar.Location = new System.Drawing.Point(785, 869);
            this.CancelRepar.Name = "CancelRepar";
            this.CancelRepar.Size = new System.Drawing.Size(125, 36);
            this.CancelRepar.TabIndex = 52;
            this.CancelRepar.Text = "Renunta";
            this.CancelRepar.UseVisualStyleBackColor = false;
            // 
            // SearchBtnRepar
            // 
            this.SearchBtnRepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.SearchBtnRepar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnRepar.Location = new System.Drawing.Point(521, 961);
            this.SearchBtnRepar.Name = "SearchBtnRepar";
            this.SearchBtnRepar.Size = new System.Drawing.Size(434, 41);
            this.SearchBtnRepar.TabIndex = 53;
            this.SearchBtnRepar.Text = "Cauta tipul de reparatie dupa denumire";
            this.SearchBtnRepar.UseVisualStyleBackColor = false;
            // 
            // SearchRepar
            // 
            this.SearchRepar.Location = new System.Drawing.Point(460, 933);
            this.SearchRepar.Name = "SearchRepar";
            this.SearchRepar.Size = new System.Drawing.Size(515, 22);
            this.SearchRepar.TabIndex = 54;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(418, 562);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(575, 469);
            this.flowLayoutPanel2.TabIndex = 55;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(418, 99);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(575, 367);
            this.flowLayoutPanel3.TabIndex = 56;
            // 
            // CatalogServRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.SearchRepar);
            this.Controls.Add(this.SearchBtnRepar);
            this.Controls.Add(this.CancelRepar);
            this.Controls.Add(this.DeleteRepar);
            this.Controls.Add(this.AddRepar);
            this.Controls.Add(this.SearchBtnServ);
            this.Controls.Add(this.SearchServ);
            this.Controls.Add(this.CancelServ);
            this.Controls.Add(this.DeleteServ);
            this.Controls.Add(this.AddServ);
            this.Controls.Add(this.ReparDescriere);
            this.Controls.Add(this.ReparMaxTimp);
            this.Controls.Add(this.ReparMinTimp);
            this.Controls.Add(this.ReparPret);
            this.Controls.Add(this.ReparActiv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ServActiv);
            this.Controls.Add(this.ServDiscountTxt);
            this.Controls.Add(this.ServDescriereTxt);
            this.Controls.Add(this.ServDenumireTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewTipContact);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "CatalogServRep";
            this.Text = "CatalogServRep";
            this.Load += new System.EventHandler(this.CatalogServRep_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogserviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogtipreparatieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dataGridViewTipContact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ServiceAutoDBDataSet serviceAutoDBDataSet;
        private System.Windows.Forms.BindingSource catalogserviciiBindingSource;
        private ServiceAutoDBDataSetTableAdapters.catalog_serviciiTableAdapter catalog_serviciiTableAdapter;
        private System.Windows.Forms.BindingSource catalogtipreparatieBindingSource;
        private ServiceAutoDBDataSetTableAdapters.catalog_tip_reparatieTableAdapter catalog_tip_reparatieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpnecesarmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpnecesarminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcatalogserviciiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label PosName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ServDenumireTxt;
        private System.Windows.Forms.TextBox ServDescriereTxt;
        private System.Windows.Forms.TextBox ServDiscountTxt;
        private System.Windows.Forms.CheckBox ServActiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ReparActiv;
        private System.Windows.Forms.TextBox ReparPret;
        private System.Windows.Forms.TextBox ReparMinTimp;
        private System.Windows.Forms.TextBox ReparMaxTimp;
        private System.Windows.Forms.TextBox ReparDescriere;
        private System.Windows.Forms.Button AddServ;
        private System.Windows.Forms.Button DeleteServ;
        private System.Windows.Forms.Button CancelServ;
        private System.Windows.Forms.TextBox SearchServ;
        private System.Windows.Forms.Button SearchBtnServ;
        private System.Windows.Forms.Button AddRepar;
        private System.Windows.Forms.Button DeleteRepar;
        private System.Windows.Forms.Button CancelRepar;
        private System.Windows.Forms.Button SearchBtnRepar;
        private System.Windows.Forms.TextBox SearchRepar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
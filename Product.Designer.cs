namespace CRUDOP2
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.OfferButton = new System.Windows.Forms.Button();
            this.DevizButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceAutoDBDataSet = new CRUDOP2.ServiceAutoDBDataSet();
            this.produsTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.produsTableAdapter();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBtnInt = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SerialTxt = new System.Windows.Forms.TextBox();
            this.Discountxt = new System.Windows.Forms.TextBox();
            this.Sellltxt = new System.Windows.Forms.TextBox();
            this.BuyTxt = new System.Windows.Forms.TextBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.CompatTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PrdctName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Serielbl = new System.Windows.Forms.Label();
            this.OriginalAftermarkt = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compatibilitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalsauaftermarketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costachizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costvanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountmaximDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CRUDOP2.Properties.Resources.produse_removebg_preview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(388, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(1588, 143);
            this.button1.TabIndex = 5;
            this.button1.Text = "        Produse";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataMember = "produs";
            this.produsBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // serviceAutoDBDataSet
            // 
            this.serviceAutoDBDataSet.DataSetName = "ServiceAutoDBDataSet";
            this.serviceAutoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produsTableAdapter
            // 
            this.produsTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(425, 739);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1065, 22);
            this.Search.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(527, 804);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(383, 53);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Cauta dupa denumire";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBtnInt
            // 
            this.SearchBtnInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.SearchBtnInt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnInt.Location = new System.Drawing.Point(1007, 804);
            this.SearchBtnInt.Name = "SearchBtnInt";
            this.SearchBtnInt.Size = new System.Drawing.Size(383, 52);
            this.SearchBtnInt.TabIndex = 6;
            this.SearchBtnInt.Text = "Cauta la furnizor";
            this.SearchBtnInt.UseVisualStyleBackColor = false;
            this.SearchBtnInt.Click += new System.EventHandler(this.SearchBtnInt_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1581, 506);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(308, 67);
            this.Add.TabIndex = 8;
            this.Add.Text = "Salveaza";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(1581, 689);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(308, 67);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Renunta";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1581, 598);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(308, 67);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Sterge";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SerialTxt
            // 
            this.SerialTxt.Location = new System.Drawing.Point(1739, 241);
            this.SerialTxt.Name = "SerialTxt";
            this.SerialTxt.Size = new System.Drawing.Size(187, 22);
            this.SerialTxt.TabIndex = 12;
            // 
            // Discountxt
            // 
            this.Discountxt.Location = new System.Drawing.Point(1739, 381);
            this.Discountxt.Name = "Discountxt";
            this.Discountxt.Size = new System.Drawing.Size(187, 22);
            this.Discountxt.TabIndex = 14;
            // 
            // Sellltxt
            // 
            this.Sellltxt.Location = new System.Drawing.Point(1739, 353);
            this.Sellltxt.Name = "Sellltxt";
            this.Sellltxt.Size = new System.Drawing.Size(187, 22);
            this.Sellltxt.TabIndex = 15;
            // 
            // BuyTxt
            // 
            this.BuyTxt.Location = new System.Drawing.Point(1739, 323);
            this.BuyTxt.Name = "BuyTxt";
            this.BuyTxt.Size = new System.Drawing.Size(187, 22);
            this.BuyTxt.TabIndex = 16;
            // 
            // DescTxt
            // 
            this.DescTxt.Location = new System.Drawing.Point(1739, 295);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(187, 22);
            this.DescTxt.TabIndex = 17;
            // 
            // CompatTxt
            // 
            this.CompatTxt.Location = new System.Drawing.Point(1739, 267);
            this.CompatTxt.Name = "CompatTxt";
            this.CompatTxt.Size = new System.Drawing.Size(187, 22);
            this.CompatTxt.TabIndex = 18;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(1739, 215);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(187, 22);
            this.NameTxt.TabIndex = 19;
            // 
            // PrdctName
            // 
            this.PrdctName.AutoSize = true;
            this.PrdctName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrdctName.Location = new System.Drawing.Point(1582, 215);
            this.PrdctName.Name = "PrdctName";
            this.PrdctName.Size = new System.Drawing.Size(85, 20);
            this.PrdctName.TabIndex = 20;
            this.PrdctName.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1577, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Provenienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1577, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Discount Maxim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1577, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cost Vanzare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1577, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cost Achizitie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1577, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Descriere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1577, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Compatibil";
            // 
            // Serielbl
            // 
            this.Serielbl.AutoSize = true;
            this.Serielbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serielbl.Location = new System.Drawing.Point(1582, 243);
            this.Serielbl.Name = "Serielbl";
            this.Serielbl.Size = new System.Drawing.Size(47, 20);
            this.Serielbl.TabIndex = 27;
            this.Serielbl.Text = "Serie";
            // 
            // OriginalAftermarkt
            // 
            this.OriginalAftermarkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginalAftermarkt.FormattingEnabled = true;
            this.OriginalAftermarkt.Items.AddRange(new object[] {
            "Original",
            "AfterMarket"});
            this.OriginalAftermarkt.Location = new System.Drawing.Point(1739, 409);
            this.OriginalAftermarkt.Name = "OriginalAftermarkt";
            this.OriginalAftermarkt.Size = new System.Drawing.Size(187, 24);
            this.OriginalAftermarkt.TabIndex = 28;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.compatibilitateDataGridViewTextBoxColumn,
            this.originalsauaftermarketDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.costachizitieDataGridViewTextBoxColumn,
            this.costvanzareDataGridViewTextBoxColumn,
            this.discountmaximDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.produsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(470, 189);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(992, 498);
            this.dataGridView.TabIndex = 29;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
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
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.Width = 125;
            // 
            // compatibilitateDataGridViewTextBoxColumn
            // 
            this.compatibilitateDataGridViewTextBoxColumn.DataPropertyName = "compatibilitate";
            this.compatibilitateDataGridViewTextBoxColumn.HeaderText = "Compatibilitate";
            this.compatibilitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compatibilitateDataGridViewTextBoxColumn.Name = "compatibilitateDataGridViewTextBoxColumn";
            this.compatibilitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // originalsauaftermarketDataGridViewTextBoxColumn
            // 
            this.originalsauaftermarketDataGridViewTextBoxColumn.DataPropertyName = "original_sau_aftermarket";
            this.originalsauaftermarketDataGridViewTextBoxColumn.HeaderText = "Provenienta";
            this.originalsauaftermarketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originalsauaftermarketDataGridViewTextBoxColumn.Name = "originalsauaftermarketDataGridViewTextBoxColumn";
            this.originalsauaftermarketDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.Width = 125;
            // 
            // costachizitieDataGridViewTextBoxColumn
            // 
            this.costachizitieDataGridViewTextBoxColumn.DataPropertyName = "cost_achizitie";
            this.costachizitieDataGridViewTextBoxColumn.HeaderText = "Cost Achizitie";
            this.costachizitieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costachizitieDataGridViewTextBoxColumn.Name = "costachizitieDataGridViewTextBoxColumn";
            this.costachizitieDataGridViewTextBoxColumn.Width = 125;
            // 
            // costvanzareDataGridViewTextBoxColumn
            // 
            this.costvanzareDataGridViewTextBoxColumn.DataPropertyName = "cost_vanzare";
            this.costvanzareDataGridViewTextBoxColumn.HeaderText = "Cost Vanzare";
            this.costvanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costvanzareDataGridViewTextBoxColumn.Name = "costvanzareDataGridViewTextBoxColumn";
            this.costvanzareDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountmaximDataGridViewTextBoxColumn
            // 
            this.discountmaximDataGridViewTextBoxColumn.DataPropertyName = "discount_maxim";
            this.discountmaximDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountmaximDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountmaximDataGridViewTextBoxColumn.Name = "discountmaximDataGridViewTextBoxColumn";
            this.discountmaximDataGridViewTextBoxColumn.Width = 125;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1553, 173);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(373, 314);
            this.flowLayoutPanel3.TabIndex = 42;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OriginalAftermarkt);
            this.Controls.Add(this.Serielbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrdctName);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.CompatTxt);
            this.Controls.Add(this.DescTxt);
            this.Controls.Add(this.BuyTxt);
            this.Controls.Add(this.Sellltxt);
            this.Controls.Add(this.Discountxt);
            this.Controls.Add(this.SerialTxt);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SearchBtnInt);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private ServiceAutoDBDataSet serviceAutoDBDataSet;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private ServiceAutoDBDataSetTableAdapters.produsTableAdapter produsTableAdapter;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button SearchBtnInt;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox SerialTxt;
        private System.Windows.Forms.TextBox Discountxt;
        private System.Windows.Forms.TextBox Sellltxt;
        private System.Windows.Forms.TextBox BuyTxt;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.TextBox CompatTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label PrdctName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Serielbl;
        private System.Windows.Forms.ComboBox OriginalAftermarkt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compatibilitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalsauaftermarketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costachizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costvanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountmaximDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
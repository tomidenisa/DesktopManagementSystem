namespace CRUDOP2
{
    partial class Vehicul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicul));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.OfferButton = new System.Windows.Forms.Button();
            this.DevizButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.VehiculdataGridView = new System.Windows.Forms.DataGridView();
            this.idvehicul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesasiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrinmatriculareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anfabricatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvehiculDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceAutoDBDataSet = new CRUDOP2.ServiceAutoDBDataSet();
            this.vehiculTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.vehiculTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddVehicul = new System.Windows.Forms.Button();
            this.DeleteVehicul = new System.Windows.Forms.Button();
            this.CancelVehicul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DetaliiTxt = new System.Windows.Forms.TextBox();
            this.ProducatorTextBox = new System.Windows.Forms.TextBox();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.SasiuTxt = new System.Windows.Forms.TextBox();
            this.InmatriculareTxt = new System.Windows.Forms.TextBox();
            this.FabricatieTxt = new System.Windows.Forms.TextBox();
            this.ClientCombo = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.ClientTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipvehiculcombo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // 
            // VehiculdataGridView
            // 
            this.VehiculdataGridView.AutoGenerateColumns = false;
            this.VehiculdataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.VehiculdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvehicul,
            this.seriesasiuDataGridViewTextBoxColumn,
            this.nrinmatriculareDataGridViewTextBoxColumn,
            this.anfabricatieDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn,
            this.datainregistrareDataGridViewTextBoxColumn,
            this.idclient,
            this.tipvehiculDataGridViewTextBoxColumn,
            this.producatorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.VehiculdataGridView.DataSource = this.vehiculBindingSource;
            this.VehiculdataGridView.Location = new System.Drawing.Point(536, 503);
            this.VehiculdataGridView.Name = "VehiculdataGridView";
            this.VehiculdataGridView.RowHeadersWidth = 51;
            this.VehiculdataGridView.RowTemplate.Height = 24;
            this.VehiculdataGridView.Size = new System.Drawing.Size(1301, 451);
            this.VehiculdataGridView.TabIndex = 4;
            this.VehiculdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehiculdataGridView_CellContentClick);
            // 
            // idvehicul
            // 
            this.idvehicul.DataPropertyName = "id";
            this.idvehicul.HeaderText = "ID";
            this.idvehicul.MinimumWidth = 6;
            this.idvehicul.Name = "idvehicul";
            this.idvehicul.ReadOnly = true;
            this.idvehicul.Width = 125;
            // 
            // seriesasiuDataGridViewTextBoxColumn
            // 
            this.seriesasiuDataGridViewTextBoxColumn.DataPropertyName = "serie_sasiu";
            this.seriesasiuDataGridViewTextBoxColumn.HeaderText = "Serie Sasiu";
            this.seriesasiuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seriesasiuDataGridViewTextBoxColumn.Name = "seriesasiuDataGridViewTextBoxColumn";
            this.seriesasiuDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrinmatriculareDataGridViewTextBoxColumn
            // 
            this.nrinmatriculareDataGridViewTextBoxColumn.DataPropertyName = "nr_inmatriculare";
            this.nrinmatriculareDataGridViewTextBoxColumn.HeaderText = "Nr Înmatriculare";
            this.nrinmatriculareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrinmatriculareDataGridViewTextBoxColumn.Name = "nrinmatriculareDataGridViewTextBoxColumn";
            this.nrinmatriculareDataGridViewTextBoxColumn.Width = 125;
            // 
            // anfabricatieDataGridViewTextBoxColumn
            // 
            this.anfabricatieDataGridViewTextBoxColumn.DataPropertyName = "an_fabricatie";
            this.anfabricatieDataGridViewTextBoxColumn.HeaderText = "An Fabricație";
            this.anfabricatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anfabricatieDataGridViewTextBoxColumn.Name = "anfabricatieDataGridViewTextBoxColumn";
            this.anfabricatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            this.detaliiDataGridViewTextBoxColumn.Width = 125;
            // 
            // datainregistrareDataGridViewTextBoxColumn
            // 
            this.datainregistrareDataGridViewTextBoxColumn.DataPropertyName = "data_inregistrare";
            this.datainregistrareDataGridViewTextBoxColumn.HeaderText = "Data Înregistrare";
            this.datainregistrareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datainregistrareDataGridViewTextBoxColumn.Name = "datainregistrareDataGridViewTextBoxColumn";
            this.datainregistrareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idclient
            // 
            this.idclient.DataPropertyName = "id_client";
            this.idclient.HeaderText = "Id Client";
            this.idclient.MinimumWidth = 6;
            this.idclient.Name = "idclient";
            this.idclient.Width = 125;
            // 
            // tipvehiculDataGridViewTextBoxColumn
            // 
            this.tipvehiculDataGridViewTextBoxColumn.DataPropertyName = "tip_vehicul";
            this.tipvehiculDataGridViewTextBoxColumn.HeaderText = "Tip Vehicul";
            this.tipvehiculDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipvehiculDataGridViewTextBoxColumn.Name = "tipvehiculDataGridViewTextBoxColumn";
            this.tipvehiculDataGridViewTextBoxColumn.Width = 125;
            // 
            // producatorDataGridViewTextBoxColumn
            // 
            this.producatorDataGridViewTextBoxColumn.DataPropertyName = "producator";
            this.producatorDataGridViewTextBoxColumn.HeaderText = "Producător";
            this.producatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.producatorDataGridViewTextBoxColumn.Name = "producatorDataGridViewTextBoxColumn";
            this.producatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehiculBindingSource
            // 
            this.vehiculBindingSource.DataMember = "vehicul";
            this.vehiculBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // serviceAutoDBDataSet
            // 
            this.serviceAutoDBDataSet.DataSetName = "ServiceAutoDBDataSet";
            this.serviceAutoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculTableAdapter
            // 
            this.vehiculTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "An Fabricație";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nr Înmatriculare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Detalii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tip Vehicul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Producător";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Serie Șasiu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "Model";
            // 
            // AddVehicul
            // 
            this.AddVehicul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.AddVehicul.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVehicul.Location = new System.Drawing.Point(1019, 82);
            this.AddVehicul.Name = "AddVehicul";
            this.AddVehicul.Size = new System.Drawing.Size(172, 63);
            this.AddVehicul.TabIndex = 75;
            this.AddVehicul.Text = "Salveaza";
            this.AddVehicul.UseVisualStyleBackColor = false;
            this.AddVehicul.Click += new System.EventHandler(this.AddVehicul_Click);
            // 
            // DeleteVehicul
            // 
            this.DeleteVehicul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.DeleteVehicul.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteVehicul.Location = new System.Drawing.Point(1019, 178);
            this.DeleteVehicul.Name = "DeleteVehicul";
            this.DeleteVehicul.Size = new System.Drawing.Size(172, 60);
            this.DeleteVehicul.TabIndex = 76;
            this.DeleteVehicul.Text = "Sterge";
            this.DeleteVehicul.UseVisualStyleBackColor = false;
            this.DeleteVehicul.Click += new System.EventHandler(this.DeleteVehicul_Click);
            // 
            // CancelVehicul
            // 
            this.CancelVehicul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.CancelVehicul.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelVehicul.Location = new System.Drawing.Point(1019, 266);
            this.CancelVehicul.Name = "CancelVehicul";
            this.CancelVehicul.Size = new System.Drawing.Size(172, 70);
            this.CancelVehicul.TabIndex = 77;
            this.CancelVehicul.Text = "Renunta";
            this.CancelVehicul.UseVisualStyleBackColor = false;
            this.CancelVehicul.Click += new System.EventHandler(this.CancelVehicul_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1396, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 57);
            this.button1.TabIndex = 113;
            this.button1.Text = "Navigheaza înapoi la Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(536, 995);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(799, 22);
            this.Search.TabIndex = 114;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1373, 983);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(464, 41);
            this.SearchBtn.TabIndex = 115;
            this.SearchBtn.Text = "Cauta Vehicul dupa Serie Sasiu sau Model";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DetaliiTxt
            // 
            this.DetaliiTxt.Location = new System.Drawing.Point(685, 178);
            this.DetaliiTxt.Name = "DetaliiTxt";
            this.DetaliiTxt.Size = new System.Drawing.Size(194, 22);
            this.DetaliiTxt.TabIndex = 117;
            // 
            // ProducatorTextBox
            // 
            this.ProducatorTextBox.Location = new System.Drawing.Point(685, 316);
            this.ProducatorTextBox.Name = "ProducatorTextBox";
            this.ProducatorTextBox.Size = new System.Drawing.Size(194, 22);
            this.ProducatorTextBox.TabIndex = 119;
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(685, 365);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(194, 22);
            this.ModelTxt.TabIndex = 120;
            // 
            // SasiuTxt
            // 
            this.SasiuTxt.Location = new System.Drawing.Point(685, 26);
            this.SasiuTxt.Name = "SasiuTxt";
            this.SasiuTxt.Size = new System.Drawing.Size(194, 22);
            this.SasiuTxt.TabIndex = 122;
            // 
            // InmatriculareTxt
            // 
            this.InmatriculareTxt.Location = new System.Drawing.Point(685, 73);
            this.InmatriculareTxt.Name = "InmatriculareTxt";
            this.InmatriculareTxt.Size = new System.Drawing.Size(194, 22);
            this.InmatriculareTxt.TabIndex = 123;
            // 
            // FabricatieTxt
            // 
            this.FabricatieTxt.Location = new System.Drawing.Point(685, 123);
            this.FabricatieTxt.Name = "FabricatieTxt";
            this.FabricatieTxt.Size = new System.Drawing.Size(194, 22);
            this.FabricatieTxt.TabIndex = 124;
            // 
            // ClientCombo
            // 
            this.ClientCombo.DataSource = this.clientBindingSource;
            this.ClientCombo.DisplayMember = "id";
            this.ClientCombo.FormattingEnabled = true;
            this.ClientCombo.Location = new System.Drawing.Point(685, 218);
            this.ClientCombo.Name = "ClientCombo";
            this.ClientCombo.Size = new System.Drawing.Size(194, 24);
            this.ClientCombo.TabIndex = 125;
            this.ClientCombo.ValueMember = "id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // vehiculBindingSource1
            // 
            this.vehiculBindingSource1.DataMember = "vehicul";
            this.vehiculBindingSource1.DataSource = this.serviceAutoDBDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tipvehiculcombo
            // 
            this.tipvehiculcombo.FormattingEnabled = true;
            this.tipvehiculcombo.Items.AddRange(new object[] {
            "Autovehicul",
            "Atoutilitara"});
            this.tipvehiculcombo.Location = new System.Drawing.Point(685, 268);
            this.tipvehiculcombo.Name = "tipvehiculcombo";
            this.tipvehiculcombo.Size = new System.Drawing.Size(194, 24);
            this.tipvehiculcombo.TabIndex = 126;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(506, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(742, 410);
            this.flowLayoutPanel3.TabIndex = 127;
            // 
            // Vehicul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tipvehiculcombo);
            this.Controls.Add(this.ClientCombo);
            this.Controls.Add(this.FabricatieTxt);
            this.Controls.Add(this.InmatriculareTxt);
            this.Controls.Add(this.SasiuTxt);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.ProducatorTextBox);
            this.Controls.Add(this.DetaliiTxt);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelVehicul);
            this.Controls.Add(this.DeleteVehicul);
            this.Controls.Add(this.AddVehicul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VehiculdataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehicul";
            this.Text = "Vehicul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vehicul_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.DataGridView VehiculdataGridView;
        private ServiceAutoDBDataSet serviceAutoDBDataSet;
        private System.Windows.Forms.BindingSource vehiculBindingSource;
        private ServiceAutoDBDataSetTableAdapters.vehiculTableAdapter vehiculTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddVehicul;
        private System.Windows.Forms.Button DeleteVehicul;
        private System.Windows.Forms.Button CancelVehicul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox DetaliiTxt;
        private System.Windows.Forms.TextBox ProducatorTextBox;
        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.TextBox SasiuTxt;
        private System.Windows.Forms.TextBox InmatriculareTxt;
        private System.Windows.Forms.TextBox FabricatieTxt;
        private System.Windows.Forms.ComboBox ClientCombo;
        private System.Windows.Forms.BindingSource vehiculBindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ServiceAutoDBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvehicul;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesasiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrinmatriculareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anfabricatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipvehiculDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox tipvehiculcombo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
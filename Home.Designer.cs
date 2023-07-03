namespace CRUDOP2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serviceAutoDBDataSet = new CRUDOP2.ServiceAutoDBDataSet();
            this.punctLucruServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punct_Lucru_ServiceTableAdapter = new CRUDOP2.ServiceAutoDBDataSetTableAdapters.Punct_Lucru_ServiceTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.OfferButton = new System.Windows.Forms.Button();
            this.DevizButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AddCantitate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pozitie_angajatTableAdapter1 = new CRUDOP2.ServiceAutoDBDataSet1TableAdapters.pozitie_angajatTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctLucruServiceBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceAutoDBDataSet
            // 
            this.serviceAutoDBDataSet.DataSetName = "ServiceAutoDBDataSet";
            this.serviceAutoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punctLucruServiceBindingSource
            // 
            this.punctLucruServiceBindingSource.DataMember = "Punct_Lucru_Service";
            this.punctLucruServiceBindingSource.DataSource = this.serviceAutoDBDataSet;
            // 
            // punct_Lucru_ServiceTableAdapter
            // 
            this.punct_Lucru_ServiceTableAdapter.ClearBeforeFill = true;
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
            this.flowLayoutPanel1.TabIndex = 0;
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
            // AddCantitate
            // 
            this.AddCantitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.AddCantitate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCantitate.Location = new System.Drawing.Point(410, 115);
            this.AddCantitate.Name = "AddCantitate";
            this.AddCantitate.Size = new System.Drawing.Size(305, 65);
            this.AddCantitate.TabIndex = 49;
            this.AddCantitate.Text = "Navigheaza la notificari";
            this.AddCantitate.UseVisualStyleBackColor = false;
            this.AddCantitate.Click += new System.EventHandler(this.AddCantitate_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CRUDOP2.Properties.Resources.cr1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(394, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(824, 89);
            this.button1.TabIndex = 50;
            this.button1.Text = "        Acasa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1345, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "labelDateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(845, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "label5";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 37);
            this.label8.TabIndex = 56;
            this.label8.Text = "În așteptare";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(3)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 37);
            this.label7.TabIndex = 57;
            this.label7.Text = "În progres";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lime;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(329, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 37);
            this.label9.TabIndex = 58;
            this.label9.Text = "Finalizată";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CRUDOP2.Properties.Resources.programari_removebg_preview;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(410, 260);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(392, 57);
            this.button2.TabIndex = 59;
            this.button2.Text = "        Programare";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1573, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "label6";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::CRUDOP2.Properties.Resources.administrare_removebg_preview;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1441, 317);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(344, 61);
            this.button3.TabIndex = 61;
            this.button3.Text = "       Angajati";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightBlue;
            this.chart1.BorderlineColor = System.Drawing.Color.LightBlue;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(541, 638);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(447, 300);
            this.chart1.TabIndex = 62;
            this.chart1.Text = "chart1";
            // 
            // pozitie_angajatTableAdapter1
            // 
            this.pozitie_angajatTableAdapter1.ClearBeforeFill = true;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.LightBlue;
            this.chart2.BorderlineColor = System.Drawing.Color.LightBlue;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(1348, 638);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(549, 320);
            this.chart2.TabIndex = 63;
            this.chart2.Text = "chart2";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(450, 428);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(538, 48);
            this.flowLayoutPanel3.TabIndex = 128;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1379, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(305, 65);
            this.button4.TabIndex = 129;
            this.button4.Text = "Navigheaza la notificari";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddCantitate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "Home";
            this.Text = "Acasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctLucruServiceBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ServiceAutoDBDataSet serviceAutoDBDataSet;
        private System.Windows.Forms.BindingSource punctLucruServiceBindingSource;
        private ServiceAutoDBDataSetTableAdapters.Punct_Lucru_ServiceTableAdapter punct_Lucru_ServiceTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button OfferButton;
        private System.Windows.Forms.Button DevizButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AddCantitate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ServiceAutoDBDataSet1TableAdapters.pozitie_angajatTableAdapter pozitie_angajatTableAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button4;
    }
}


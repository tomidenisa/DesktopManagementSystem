﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home formhomp = new Home();
            formhomp.Show();
        }

        private void ProgramButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment formApp = new Appointment();
            formApp.Show();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Product formProduct = new Product();
            formProduct.Show();
        }

        private void OfferButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Offer formOffer = new Offer();

            formOffer.Show();
        }

        private void DevizButton_Click(object sender, EventArgs e)
        {
            Deviz formDeviz = new Deviz();
            this.Hide();
            formDeviz.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Management formmgmt = new Management();
            this.Hide();
            formmgmt.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Registration formRegi = new Registration();
            this.Hide();
            formRegi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiPctLucru formAng = new AngajatiPctLucru();
            formAng.Show();
        }

        private void ClientContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientContact formClt = new ClientContact();
            formClt.Show();
        }

        private void Vehicul_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicul formVeh = new Vehicul();
            formVeh.Show();
        }

        private void CatalogServiciiReparatii_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogServRep formSrv= new CatalogServRep();
            formSrv.Show();
        }

        private void OferteServiciiReparatii_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfertaServRep formOf = new OfertaServRep();
             formOf.Show();
        }
    }
}

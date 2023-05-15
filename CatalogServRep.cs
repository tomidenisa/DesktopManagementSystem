using System;
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
    public partial class CatalogServRep : Form
    {
        public CatalogServRep()
        {
            InitializeComponent();
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

        private void CatalogServRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.catalog_tip_reparatie' table. You can move, or remove it, as needed.
            this.catalog_tip_reparatieTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_tip_reparatie);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.catalog_servicii' table. You can move, or remove it, as needed.
            this.catalog_serviciiTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_servicii);
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

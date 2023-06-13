using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class OfertaServRep : Form
    {
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        oferte_servicii ofertaservicii = new oferte_servicii();
        oferta_tip_reparatie ofertareparatie = new oferta_tip_reparatie();
        int id_servicii = 0;
        int id_reparatii = 0;
        public OfertaServRep()
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

        private void OfertaServRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.catalog_tip_reparatie' table. You can move, or remove it, as needed.
            this.catalog_tip_reparatieTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_tip_reparatie);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.serviceAutoDBDataSet.Client);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.serviceAutoDBDataSet.Contact);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.catalog_servicii' table. You can move, or remove it, as needed.
            this.catalog_serviciiTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_servicii);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.oferta_tip_reparatie' table. You can move, or remove it, as needed.
            this.oferta_tip_reparatieTableAdapter.Fill(this.serviceAutoDBDataSet.oferta_tip_reparatie);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.oferte_servicii' table. You can move, or remove it, as needed.
            this.oferte_serviciiTableAdapter.Fill(this.serviceAutoDBDataSet.oferte_servicii);
            this.WindowState = FormWindowState.Maximized;
            SetDataInGridViewServicii();
            SetDataInGridViewReparatii();
            ClearDataServicii();
            ClearDataReparatii();

        }
        public void SetDataInGridViewServicii()
        {
            datagridofertaserviciu.AutoGenerateColumns = false;
            datagridofertaserviciu.DataSource = db.oferte_servicii.ToList<oferte_servicii>();
        }
        public void SetDataInGridViewReparatii()
        {
            datagridofertatipreparatie.AutoGenerateColumns = false;
            datagridofertatipreparatie.DataSource = db.oferta_tip_reparatie.ToList<oferta_tip_reparatie>();
        }
        public void ClearDataServicii()
        {
            OfferServDescriere.Text = OfferServPret.Text =  string.Empty;
            OfferClientCombo.SelectedIndex = -1;
            OfferCatalogServCombo.SelectedIndex = -1;
            OfferContactCombo.SelectedIndex = -1;
            DeleteOfferServ.Enabled = true;
            AddOfferServ.Text = "Salveaza";
            id_servicii = 0;
        }
        public void ClearDataReparatii()
        {
            ReparPretTxt.Text  = string.Empty;
            ReparOfferServCombo.SelectedIndex = -1;
            ReparCatalogReparCombo.SelectedIndex = -1;
            DeleteOfferRepar.Enabled = true;
            SaveOfferRepar.Text = "Salveaza";
            id_reparatii = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientContact client = new ClientContact();
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogServRep catalogServRep = new CatalogServRep();
            catalogServRep.Show();
        }
        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
        }
        private void AddOfferServ_Click(object sender, EventArgs e)
        {
            if (OfferCatalogServCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Catalog Servicii.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OfferClientCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Client.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OfferContactCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Contact.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ofertaservicii.descriere = OfferServDescriere.Text.Trim();
            ofertaservicii.pret = decimal.Parse(OfferServPret.Text);
            ofertaservicii.id_catalog_servicii = Convert.ToInt32(OfferCatalogServCombo.SelectedValue);
            ofertaservicii.id_client = Convert.ToInt32(OfferClientCombo.SelectedValue);
            ofertaservicii.id_contact = Convert.ToInt32(OfferContactCombo.SelectedValue);
            ofertaservicii.data_inregistrare = DateTime.Now;
            if (id_servicii > 0)
                db.Entry(ofertaservicii).State = EntityState.Modified;
            else
            {
                db.oferte_servicii.Add(ofertaservicii);
            }
            List<FieldInfo> fields = new List<FieldInfo>
{
    new FieldInfo { TextBox = OfferServPret, FieldName = "Pret", MaxLength = 50 }
};

            foreach (var field in fields)
            {
                if (!decimal.TryParse(field.TextBox.Text.Trim(), out decimal price) || price <= 0)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru preț", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru preț");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, String.Empty);
                }
            }

            db.SaveChanges();
            ClearDataServicii();
            SetDataInGridViewServicii();
            MessageBox.Show("Inregistrare salvata cu succes");

        }

        private void SaveOfferRepar_Click(object sender, EventArgs e)
        {
            if (ReparCatalogReparCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Catalog Reparatii.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ReparOfferServCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Oferte Servicii.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ofertareparatie.pret_tip_reparatie = decimal.Parse(ReparPretTxt.Text);
            ofertareparatie.id_catalog_tip_reparatie = Convert.ToInt32(ReparCatalogReparCombo.SelectedValue);
            ofertareparatie.id_oferte_servicii = Convert.ToInt32(ReparOfferServCombo.SelectedValue);
            if (id_reparatii > 0)
                db.Entry(ofertareparatie).State = EntityState.Modified;
            else
            {
                db.oferta_tip_reparatie.Add(ofertareparatie);
            }
            List<FieldInfo> fields = new List<FieldInfo>
{
    new FieldInfo { TextBox = ReparPretTxt, FieldName = "Pret", MaxLength = 50 }
};

            foreach (var field in fields)
            {
                if (!decimal.TryParse(field.TextBox.Text.Trim(), out decimal price) || price <= 0)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru preț", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru preț");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, String.Empty);
                }
            }

            db.SaveChanges();
            ClearDataReparatii();
            SetDataInGridViewReparatii();
            MessageBox.Show("Inregistrare salvata cu succes");
        }

        private void DeleteOfferServ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.oferte_servicii.Remove(ofertaservicii);
                db.SaveChanges();
                ClearDataServicii();
                SetDataInGridViewReparatii();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void DeleteOfferRepar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.oferta_tip_reparatie.Remove(ofertareparatie);
                db.SaveChanges();
                ClearDataReparatii();
                SetDataInGridViewReparatii();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void CancelOfferRepar_Click(object sender, EventArgs e)
        {
            ClearDataReparatii();
        }

        private void CancelOfferServ_Click(object sender, EventArgs e)
        {
            ClearDataServicii();
        }

        private void datagridofertaserviciu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridofertaserviciu.CurrentCell.RowIndex != -1)
            {
                id_servicii = Convert.ToInt32(datagridofertaserviciu.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                ofertaservicii = db.oferte_servicii.Where(x => x.id == id_servicii).FirstOrDefault();
                OfferServDescriere.Text = ofertaservicii.descriere;
                OfferServPret.Text = ofertaservicii.pret?.ToString();
                OfferClientCombo.SelectedValue = ofertaservicii.id_client;
                OfferContactCombo.SelectedValue = ofertaservicii.id_contact;
                OfferCatalogServCombo.SelectedValue = ofertaservicii.id_catalog_servicii;
            }
            AddOfferServ.Text = "Update";
            DeleteOfferServ.Enabled = true;
        }

        private void datagridofertatipreparatie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(datagridofertatipreparatie.CurrentCell.RowIndex != -1)
            {
                id_reparatii = Convert.ToInt32(datagridofertatipreparatie.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                ofertareparatie = db.oferta_tip_reparatie.Where(x => x.id == id_reparatii).FirstOrDefault();
                ReparPretTxt.Text = ofertareparatie.pret_tip_reparatie?.ToString();
                ReparCatalogReparCombo.SelectedValue = ofertareparatie.id_catalog_tip_reparatie;
                ReparOfferServCombo.SelectedValue = ofertareparatie.id_oferte_servicii;
            }
            SaveOfferRepar.Text = "Update";
            DeleteOfferRepar.Enabled = true;
        }

        private void SearchBtnOfferServ_Click(object sender, EventArgs e)
        {
            {
                string searchValue = SearchBtnOfferServ.Text;
                datagridofertaserviciu.ClearSelection();
                datagridofertaserviciu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in datagridofertaserviciu.Rows)
                    {
                        //if (row.Cells[1].Value.ToString().Contains(searchValue))
                        if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            valueResult = false;
                            //break;

                        }
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Inregistrare inexistenta pentru cautarea " + SearchBtnOfferServ.Text, " Nu exista");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void SearchBtnOfferRepar_Click(object sender, EventArgs e)
        {
            {
                string searchValue = SearchBtnOfferRepar.Text;
                datagridofertatipreparatie.ClearSelection();
                datagridofertatipreparatie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in datagridofertatipreparatie.Rows)
                    {
                        
                        if (row.Cells[0].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            valueResult = false;
                           

                        }
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Inregistrare inexistenta pentru cautarea " + SearchBtnOfferRepar.Text, " Nu exista");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
   }

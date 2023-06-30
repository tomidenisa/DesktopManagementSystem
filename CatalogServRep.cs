using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class CatalogServRep : Form
    {
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        catalog_servicii catalogservicii = new catalog_servicii();
        catalog_tip_reparatie catalogreparatii = new catalog_tip_reparatie();
        int id_catalog_servicii = 0;
        int id_catalog_reparatii = 0;
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
            this.catalog_tip_reparatieTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_tip_reparatie);
            this.catalog_serviciiTableAdapter.Fill(this.serviceAutoDBDataSet.catalog_servicii);
            this.WindowState = FormWindowState.Maximized;
            SetDataInGridViewCatalogServ();
            SetDataInGridViewCatalogRepar();
            ClearDataCatalogServ();
            ClearDataCatalogRepar();
        }
        public void SetDataInGridViewCatalogServ()
        {
            dataGridViewCatalogServ.AutoGenerateColumns = false;
            dataGridViewCatalogServ.DataSource = db.catalog_servicii.ToList<catalog_servicii>();
        }
        public void ClearDataCatalogServ()
        {
            ServDenumireTxt.Text = ServDescriereTxt.Text = ServDiscountTxt.Text =  string.Empty;
            ServActiv.CheckState = CheckState.Indeterminate;
            DeleteServ.Enabled = true;
            AddServ.Text = "Salveaza";
            id_catalog_servicii = 0;
        }
        public void SetDataInGridViewCatalogRepar()
        {
            dataGridViewTipReparatie.AutoGenerateColumns = false;
            dataGridViewTipReparatie.DataSource = db.catalog_tip_reparatie.ToList<catalog_tip_reparatie>();
        }
        public void ClearDataCatalogRepar()
        {
            ReparDescriere.Text = ReparPret.Text = ReparDenumire.Text = string.Empty;
            timpmaxcombo.SelectedIndex = -1;
            timpmincombo.SelectedIndex = -1;
            idcatalogserviciicombo.SelectedIndex = -1;
            DeleteRepar.Enabled = true;
            AddRepar.Text = "Salveaza";
            id_catalog_reparatii = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OfertaServRep formoferta = new OfertaServRep();
            this.Hide();
            formoferta.Show();
        }
        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
        }
        private void AddServ_Click(object sender, EventArgs e)
        {
            
            catalogservicii.descriere = ServDescriereTxt.Text.Trim();
            catalogservicii.discount = decimal.Parse(ServDiscountTxt.Text);
            catalogservicii.denumire = ServDenumireTxt.Text.Trim();
            catalogservicii.activ = ServActiv.Checked;
            if (id_catalog_servicii > 0)
                db.Entry(catalogservicii).State = EntityState.Modified;
            else
            {
                db.catalog_servicii.Add(catalogservicii);
            }
            List<FieldInfo> fields = new List<FieldInfo>
{
    new FieldInfo { TextBox = ServDiscountTxt, FieldName = "Discount", MaxLength = 50 },
    new FieldInfo {TextBox = ServDenumireTxt, FieldName = "Denumire", MaxLength = 50 },
     new FieldInfo {TextBox = ServDescriereTxt, FieldName = "Descriere", MaxLength = 100 }
};

            foreach (var field in fields)
            {
                string fieldValue = field.TextBox.Text.Trim();

                if (field.MaxLength > 0 && fieldValue.Length > field.MaxLength)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} depășește lungimea maximă permisă de {field.MaxLength} caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} depășește lungimea maximă permisă de {field.MaxLength} caractere");
                    field.TextBox.Focus();
                    return;
                }

                if (field.FieldName == "Discount" && (!decimal.TryParse(fieldValue, out decimal price) || price <= 0))
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru discount", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru discount");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, string.Empty);
                }
            }

            db.SaveChanges();
            ClearDataCatalogServ();
            SetDataInGridViewCatalogServ();
            MessageBox.Show("Inregistrare salvata cu succes");


        }

        private void AddRepar_Click(object sender, EventArgs e)
        {
            if (timpmincombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Timpul Minim Necesar in ore.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timpmaxcombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Timpul Maxim Necesar in ore.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timpmaxcombo.SelectedIndex < timpmincombo.SelectedIndex) 
            {
                MessageBox.Show("Valoarea din campul Timp Minim este mai mare decat cea din Timp Maxim.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idcatalogserviciicombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Catalog Servicii.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catalogreparatii.descriere = ReparDescriere.Text.Trim();
            catalogreparatii.pret = decimal.Parse(ReparPret.Text);
            catalogreparatii.denumire = ReparDenumire.Text.Trim();
            catalogreparatii.activ = ReparActiv.Checked;
            catalogreparatii.timp_necesar_max = Convert.ToInt32( timpmaxcombo.SelectedItem );
            catalogreparatii.timp_necesar_min = Convert.ToInt32( timpmincombo.SelectedItem );
            catalogreparatii.id_catalog_servicii = Convert.ToInt32(idcatalogserviciicombo.SelectedValue);
            if (id_catalog_reparatii > 0)
                db.Entry(catalogreparatii).State = EntityState.Modified;
            else
            {
                db.catalog_tip_reparatie.Add(catalogreparatii);
            }
            List<FieldInfo> fields = new List<FieldInfo>
{
    new FieldInfo { TextBox = ReparPret, FieldName = "Pret", MaxLength = 50 },
    new FieldInfo {TextBox = ReparDenumire, FieldName = "Denumire", MaxLength = 50 },
     new FieldInfo {TextBox = ReparDescriere, FieldName = "Descriere", MaxLength = 100 }
};

            foreach (var field in fields)
            {
                string fieldValue = field.TextBox.Text.Trim();

                if (field.MaxLength > 0 && fieldValue.Length > field.MaxLength)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} depășește lungimea maximă permisă de {field.MaxLength} caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} depășește lungimea maximă permisă de {field.MaxLength} caractere");
                    field.TextBox.Focus();
                    return;
                }

                if (field.FieldName == "Pret" && (!decimal.TryParse(fieldValue, out decimal price) || price <= 0))
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru discount", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, trebuie introdus un număr valid pentru discount");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, string.Empty);
                }
            }

            db.SaveChanges();
            ClearDataCatalogRepar();
            SetDataInGridViewCatalogRepar();
            MessageBox.Show("Inregistrare salvata cu succes");
        }

        private void DeleteRepar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.catalog_tip_reparatie.Remove(catalogreparatii);
                db.SaveChanges();
                ClearDataCatalogRepar();
                SetDataInGridViewCatalogRepar();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void DeleteServ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.catalog_servicii.Remove(catalogservicii);
                db.SaveChanges();
                ClearDataCatalogServ();
                SetDataInGridViewCatalogServ();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void CancelServ_Click(object sender, EventArgs e)
        {
            ClearDataCatalogServ();
        }

        private void CancelRepar_Click(object sender, EventArgs e)
        {
            ClearDataCatalogRepar();
        }

        private void dataGridViewCatalogServ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCatalogServ.CurrentCell.RowIndex != -1)
            {
                id_catalog_servicii = Convert.ToInt32(dataGridViewCatalogServ.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                catalogservicii = db.catalog_servicii.Where(x => x.id == id_catalog_servicii).FirstOrDefault();
                ServDiscountTxt.Text = catalogservicii.discount?.ToString();
                ServActiv.Checked = catalogservicii.activ;
                ServDenumireTxt.Text = catalogservicii.denumire;
                ServDescriereTxt.Text = catalogservicii.descriere;
            
            }
            AddServ.Text = "Update";
            DeleteServ.Enabled = true;
        }

        private void dataGridViewTipReparatie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTipReparatie.CurrentCell.RowIndex != -1)
            {
                id_catalog_reparatii = Convert.ToInt32(dataGridViewTipReparatie.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                catalogreparatii = db.catalog_tip_reparatie.Where(x => x.id == id_catalog_reparatii).FirstOrDefault();
                ReparPret.Text = catalogreparatii.pret.ToString();
                ReparActiv.Checked = catalogreparatii.activ;
                ReparDenumire.Text = catalogreparatii.denumire;
                ReparDescriere.Text = catalogreparatii.descriere;
                catalogreparatii.timp_necesar_max = Convert.ToInt32( timpmaxcombo.SelectedItem);
                catalogreparatii.timp_necesar_min = Convert.ToInt32 (timpmincombo.SelectedItem);
                idcatalogserviciicombo.SelectedValue = catalogreparatii.id_catalog_servicii;

            }
            AddRepar.Text = "Update";
            DeleteRepar.Enabled = true;
        }

        private void SearchBtnServ_Click(object sender, EventArgs e)
        {
            {
                string searchValue = SearchBtnServ.Text;
                dataGridViewCatalogServ.ClearSelection();
                dataGridViewCatalogServ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in dataGridViewCatalogServ.Rows)
                    {
                       
                        if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            valueResult = false;
                            

                        }
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Inregistrare inexistenta pentru cautarea " + SearchBtnServ.Text, " Nu exista");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void SearchBtnRepar_Click(object sender, EventArgs e)
        {
            {
                string searchValue = SearchBtnRepar.Text;
                dataGridViewTipReparatie.ClearSelection();
                dataGridViewTipReparatie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in dataGridViewTipReparatie.Rows)
                    {
                        
                        if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            valueResult = false;
                            

                        }
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Inregistrare inexistenta pentru cautarea " + SearchBtnRepar.Text, " Nu exista");
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

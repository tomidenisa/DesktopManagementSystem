using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class ClientContact : Form
    {
        public ClientContact()
        {
            InitializeComponent();
        }
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        Tip_Contact tipcontact = new Tip_Contact();
        Contact contact = new Contact();
        Client client = new Client();
        int id_tipcontact = 0;
        int id_contact = 0;
        int id_client = 0;

        private void ClientContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.programare' table. You can move, or remove it, as needed.
            this.programareTableAdapter.Fill(this.serviceAutoDBDataSet.programare);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.serviceAutoDBDataSet.Client);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Tip_Contact' table. You can move, or remove it, as needed.
            this.tip_ContactTableAdapter.Fill(this.serviceAutoDBDataSet.Tip_Contact);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.serviceAutoDBDataSet.Contact);
            this.WindowState = FormWindowState.Maximized;

            SetDataInGridViewTipContact();
            SetDataInGridViewContact();
            SetDataInGridViewClient();
            ClearDataTipContact();
            ClearDataContact();
            ClearDataClient();

        }
        public void SetDataInGridViewTipContact()
        {
            dataGridViewTipContact.AutoGenerateColumns = false;
            dataGridViewTipContact.DataSource = db.Tip_Contact.ToList<Tip_Contact>();
        }
        public void SetDataInGridViewContact()
        {
            dataGridViewContact.AutoGenerateColumns = false;
            dataGridViewContact.DataSource = db.Contacts.ToList<Contact>();
        }
        public void SetDataInGridViewClient()
        {
            dataGridViewClient.AutoGenerateColumns = false;
            dataGridViewClient.DataSource = db.Clients.ToList<Client>();
        }
        public void ClearDataTipContact()
        {
            ContTypeNameTxt.Text = string.Empty;
            DeleteTipContact.Enabled = true;
            AddTipContact.Text = "Salveaza";
            id_tipcontact = 0;
        }
        public void ClearDataContact()
        {
            DetaliiContactTxt.Text = string.Empty;
            ClientCombo.SelectedIndex = -1;
            TipContactCombo.SelectedIndex = -1;
            ProgramareCombo.SelectedIndex = -1;
            SaveContact.Text = "Salveaza";
            id_contact = 0;
        }
        public void ClearDataClient()
        {
            CLientNameTxt.Text = ClientRegComTxt.Text = ClientAdressTxt.Text = ClientCIFTxt.Text = ClientSurnameTxt.Text =  ClientCompanyTxt.Text = ClientContTxt.Text = ClientDetailTxt.Text = ContactClientTxt.Text =  string.Empty;
            AddClient.Text = "Salveaza";
            id_client = 0;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment formApp = new Appointment();
            formApp.Show();
        }

        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClient.CurrentCell.RowIndex != -1)
            {
                id_client = Convert.ToInt32(dataGridViewClient.CurrentRow.Cells["idclient"].Value);
                client = db.Clients.Where(x => x.id == id_client).FirstOrDefault();
                ClientAdressTxt.Text = client.adresa;
                CLientNameTxt.Text = client.nume;
                ClientSurnameTxt.Text = client.prenume;
                ClientCompanyTxt.Text = client.denumire_companie;
                ClientCIFTxt.Text = client.CIF;
                ContactClientTxt.Text = client.contact;
                ClientDetailTxt.Text = client.detalii;
                ClientContTxt.Text = client.cont_bancar;
                ClientRegComTxt.Text = client.nr_reg_com;

            }
            AddClient.Text = "Update";
            DeleteClient.Enabled = true;
        }

        private void dataGridViewTipContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTipContact.CurrentCell.RowIndex != -1)
            {
                id_tipcontact = Convert.ToInt32(dataGridViewTipContact.CurrentRow.Cells["idtipcontact"].Value);
                tipcontact = db.Tip_Contact.Where(x => x.Tip_Contact_Id == id_tipcontact).FirstOrDefault();
                ContTypeNameTxt.Text = tipcontact.Denumire;
            }
            AddTipContact.Text = "Update";
            DeleteTipContact.Enabled = true;
        }

        private void dataGridViewContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewContact.CurrentCell.RowIndex != -1)
            {
                id_contact = Convert.ToInt32(dataGridViewContact.CurrentRow.Cells["idcontact"].Value);
                contact = db.Contacts.Where(x => x.Contact_Id == id_contact).FirstOrDefault();
                DetaliiContactTxt.Text = contact.Detalii;
                ProgramareCombo.SelectedValue = contact.Programare_Id;
                ClientCombo.SelectedValue= contact.Client_Id;
                TipContactCombo.SelectedValue = dataGridViewContact.CurrentRow.Cells["Tip_Contact_Id"].Value;
            }
            SaveContact.Text = "Update";
            DeleteContact.Enabled = true;
        }

        private void CancelTipContact_Click(object sender, EventArgs e)
        {
            ClearDataTipContact();
        }

        private void CancelContact_Click(object sender, EventArgs e)
        {
            ClearDataContact();
        }

        private void CancelClient_Click(object sender, EventArgs e)
        {
            ClearDataClient();
        }

        private void DeleteTipContact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Tip_Contact.Remove(tipcontact);
                db.SaveChanges();
                ClearDataTipContact();
                SetDataInGridViewTipContact();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void DeleteContact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
                ClearDataContact();
                SetDataInGridViewContact();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Clients.Remove(client);
                db.SaveChanges();
                ClearDataClient();
                SetDataInGridViewClient();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void AddTipContact_Click(object sender, EventArgs e)
        {
            tipcontact.Denumire = ContTypeNameTxt.Text.Trim();
            if (id_tipcontact > 0)
                db.Entry(tipcontact).State = EntityState.Modified;
            else
            {
                db.Tip_Contact.Add(tipcontact);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = ContTypeNameTxt, FieldName = "Denumire Contact", MaxLength = 50 }, 
     }; 
            foreach (var field in fields)
            {
                if (field.TextBox.Text.Trim().Length > field.MaxLength)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, String.Empty);
                }
            }

            db.SaveChanges();
            ClearDataTipContact();
            SetDataInGridViewTipContact();
            MessageBox.Show("Inregistrare salvata cu succes");
            TipContactCombo.DataSource = db.Tip_Contact.ToList();
            TipContactCombo.DisplayMember = "Denumire";
            TipContactCombo.ValueMember = "Tip_Contact_Id";
        }

        private void SaveContact_Click(object sender, EventArgs e)
        {
            contact.Detalii = DetaliiContactTxt.Text.Trim();
            contact.Tip_Contact_Id = Convert.ToInt32(TipContactCombo.SelectedValue);
            contact.Client_Id = (int)ClientCombo.SelectedValue;
            contact.Programare_Id = (int)ProgramareCombo.SelectedValue;
            contact.Data_Inreg = DateTime.Now;

            if (id_contact > 0)
                db.Entry(contact).State = EntityState.Modified;
            else
            {
                db.Contacts.Add(contact);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = DetaliiContactTxt, FieldName = "Detalii Contact", MaxLength = 500 },
     };
            foreach (var field in fields)
            {
                if (field.TextBox.Text.Trim().Length > field.MaxLength)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, String.Empty);
                }
            }

            db.SaveChanges();
            ClearDataContact();
            SetDataInGridViewContact();
            MessageBox.Show("Inregistrare salvata cu succes");

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            client.nume = CLientNameTxt.Text.Trim();
            client.prenume = ClientSurnameTxt.Text.Trim();
            client.denumire_companie = ClientCompanyTxt.Text.Trim();
            client.adresa = ClientAdressTxt.Text.Trim() ;
            client.cont_bancar = ClientContTxt.Text.Trim();
            client.CIF = ClientCIFTxt.Text.Trim();
            client.nr_reg_com = ClientRegComTxt.Text.Trim();
            client.detalii = ClientDetailTxt.Text.Trim();
            client.contact = ContactClientTxt.Text.Trim();
            client.data_inregistrare = DateTime.Now;
            if (id_client > 0)
                db.Entry(client).State = EntityState.Modified;
            else
            {
                db.Clients.Add(client);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = CLientNameTxt, FieldName = "Nume Client", MaxLength = 50 },
        new FieldInfo { TextBox = ClientSurnameTxt, FieldName = "Prenume Client", MaxLength = 50 },
        new FieldInfo { TextBox = ClientCompanyTxt, FieldName = "Denumire Companie Client", MaxLength = 100 },
        new FieldInfo { TextBox = ClientAdressTxt, FieldName = "Adresa Client", MaxLength = 200 },
        new FieldInfo { TextBox = ClientContTxt, FieldName = "Cont Bancar Client", MaxLength = 50 },
        new FieldInfo { TextBox = ClientDetailTxt, FieldName = "Detalii Client", MaxLength = 200 },
        new FieldInfo { TextBox = ClientCIFTxt, FieldName = "CIF Client", MaxLength = 50 },
        new FieldInfo { TextBox = ClientRegComTxt, FieldName = "Nr. Inreg. Reg. Com. Client", MaxLength = 10 },
        new FieldInfo { TextBox = ClientContTxt, FieldName = "Contact Client", MaxLength = 50 }
     };
            foreach (var field in fields)
            {
                if (field.TextBox.Text.Trim().Length > field.MaxLength)
                {
                    MessageBox.Show(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(field.TextBox, $"{field.FieldName} invalid, numar prea mare de caractere");
                    field.TextBox.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(field.TextBox, String.Empty);
                }
            }

            db.SaveChanges();
            ClearDataClient();
            SetDataInGridViewClient();
            MessageBox.Show("Inregistrare salvata cu succes");
            ClientCombo.DataSource = db.Clients.ToList();
            ClientCombo.DisplayMember = "id";
            ClientCombo.ValueMember = "id";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            {
                string searchValue = Search.Text;
                dataGridViewClient.ClearSelection();
                dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in dataGridViewClient.Rows)
                    {
                        if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        row.Cells[2].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        row.Cells[3].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            valueResult = false;
                            //break;

                        }
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Inregistrare inexistenta pentru cautarea " + Search.Text, " Nu exista");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicul vehicul = new Vehicul();
            vehicul.Show();
        }
    }
}

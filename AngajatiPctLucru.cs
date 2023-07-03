using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class AngajatiPctLucru : Form
    {
        public AngajatiPctLucru()
        {
            InitializeComponent();
        }
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        Angajat employee = new Angajat();
        pozitie_angajat pozitie = new pozitie_angajat();
        Punct_Lucru_Service pct_lucru = new Punct_Lucru_Service(); 
        int id_angajat = 0;
        int id_pozitie = 0;
        int id_pctlucru = 0;
        private void AngajatiPctLucru_Load(object sender, EventArgs e)
        {
            
            this.punct_Lucru_ServiceTableAdapter.Fill(this.serviceAutoDBDataSet.Punct_Lucru_Service);
            this.pozitie_angajatTableAdapter.Fill(this.serviceAutoDBDataSet.pozitie_angajat);

            this.WindowState = FormWindowState.Maximized;

            SetDataInGridViewPos();
            SetDataInGridViewPct();
            SetDataInGridViewEmploy();
            ClearDataPctLucru();
            ClearDataPozitie();
            ClearDataAngajat();
            EndContractPicker.ShowCheckBox = true;

        }
        public void SetDataInGridViewPct()
        {
            dataGridViewPctLucru.AutoGenerateColumns = false;
            dataGridViewPctLucru.DataSource = db.Punct_Lucru_Service.ToList<Punct_Lucru_Service>();
        }
        public void SetDataInGridViewPos()
        { 
            dataGridViewPozitie.AutoGenerateColumns = false;
            dataGridViewPozitie.DataSource = db.pozitie_angajat.ToList<pozitie_angajat>();
        }
        public void SetDataInGridViewEmploy()
        {
            AngajatdataGridView.AutoGenerateColumns = false;
            AngajatdataGridView.DataSource = db.Angajats.ToList<Angajat>();
        }
        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
        }
        private void AngajatdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AngajatdataGridView.CurrentCell.RowIndex != -1)
            {
                if (employee.DataIncheiereContract.HasValue)
                {
                    EndContractPicker.Value = (DateTime)employee.DataIncheiereContract;
                }
                else
                {
                    EndContractPicker.Value = DateTimePicker.MinimumDateTime;
                }
                id_angajat = Convert.ToInt32(AngajatdataGridView.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                employee = db.Angajats.Where(x => x.Id == id_angajat).FirstOrDefault();
                NameEmplTxt.Text = employee.Nume;
                PNameEmplTxt.Text = employee.Prenume;
                CnpEmplTxt.Text = employee.CNP;
                PosCombo.SelectedValue = employee.Id_Pozitie_Angajat;
                AdressEmplTxt.Text = employee.Adresa;
                HireDateTimePicker.Value = employee.DataAngajarii;
                PasswordTxt.Text = employee.Parola;
                StatusCombo.Text = employee.Status.ToString();

            }
            SaveAngajat.Text = "Update";
            DeleteAngajat.Enabled = true;
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
        public void ClearDataPozitie()
        {
            PosTxt.Text  = string.Empty;
            DeletePozitie.Enabled = true;
            AddPozitie.Text = "Salveaza";
            id_pozitie = 0;
        }
        public void ClearDataAngajat()
        {
            NameEmplTxt.Text = PNameEmplTxt.Text = BirthDatePicker.Text = AdressEmplTxt.Text = CnpEmplTxt.Text = HireDateTimePicker.Text = PosCombo.Text = PctLucruCombo.Text = StatusCombo.Text = EndContractPicker.Text = PasswordTxt.Text =  string.Empty;
            DeleteAngajat.Enabled = true;
            PosCombo.SelectedIndex = -1;
            PctLucruCombo.SelectedIndex = -1;
            StatusCombo.SelectedIndex = -1;
            SaveAngajat.Text = "Salveaza";
            id_angajat = 0;
        }
        public void ClearDataPctLucru()
        {
            NamePctTxt.Text = AdressPctTxt.Text = BankPctTxt.Text = CIFTxt.Text = RegisterPctTxt.Text =  string.Empty;
            DeletePct.Enabled = true;
            SavePct.Text = "Salveaza";
            id_pctlucru = 0;
        }
        private void AddPozitie_Click(object sender, EventArgs e)
        {
            pozitie.pozitie = PosTxt.Text.Trim();
            if (id_pozitie > 0)
                db.Entry(pozitie).State = EntityState.Modified;
            else
            {
                db.pozitie_angajat.Add(pozitie);
            }
            List<FieldInfo> fields = new List<FieldInfo>
            {
            new FieldInfo { TextBox = PosTxt, FieldName = "Denumire Pozitie", MaxLength = 50 },
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
            ClearDataPozitie();
            SetDataInGridViewPos();
            MessageBox.Show("Inregistrare salvata cu succes");

        }

        private void SavePct_Click(object sender, EventArgs e)
        {
            pct_lucru.Denumire = NamePctTxt.Text.Trim();
            pct_lucru.Adresa = AdressPctTxt.Text.Trim();
            pct_lucru.Cont_Bancar = BankPctTxt.Text.Trim() ;
            pct_lucru.CIF = CIFTxt.Text.Trim();
            pct_lucru.Nr_Reg_Com = RegisterPctTxt.Text.Trim();
            if (id_pctlucru > 0)
                db.Entry(pct_lucru).State = EntityState.Modified;
            else
            {
                db.Punct_Lucru_Service.Add(pct_lucru);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = NamePctTxt, FieldName = "Denumire", MaxLength = 50 },
        new FieldInfo { TextBox = AdressPctTxt, FieldName = "Adresa", MaxLength = 50 },
        new FieldInfo { TextBox = BankPctTxt, FieldName = "Cont Bancar", MaxLength = 35 },
        new FieldInfo { TextBox = CIFTxt, FieldName = "CIF", MaxLength = 10 },
        new FieldInfo { TextBox = RegisterPctTxt, FieldName = "Nr. Inreg. Reg. Com. ", MaxLength = 10 },
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
            ClearDataPctLucru();
            SetDataInGridViewPct();
            MessageBox.Show("Inregistrare salvata cu succes");
        }

        private void DeletePozitie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.pozitie_angajat.Remove(pozitie);
                db.SaveChanges();
                ClearDataPozitie();
                SetDataInGridViewPos();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void DeletePct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Punct_Lucru_Service.Remove(pct_lucru);
                db.SaveChanges();
                ClearDataPctLucru();
                SetDataInGridViewPct();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void CancelPozitie_Click(object sender, EventArgs e)
        {
            ClearDataPozitie();
        }

        private void CancelPct_Click(object sender, EventArgs e)
        {
            ClearDataPctLucru();
        }

        private void dataGridViewPctLucru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPctLucru.CurrentCell.RowIndex != -1)
            {
                id_pctlucru = Convert.ToInt32(dataGridViewPctLucru.CurrentRow.Cells["punctLucruIdDataGridViewTextBoxColumn"].Value);
                pct_lucru = db.Punct_Lucru_Service.Where(x => x.Punct_Lucru_Id == id_pctlucru).FirstOrDefault();
                NamePctTxt.Text = pct_lucru.Denumire;
                AdressPctTxt.Text = pct_lucru.Adresa;
                BankPctTxt.Text = pct_lucru.Cont_Bancar;
                CIFTxt.Text = pct_lucru.CIF;
                RegisterPctTxt.Text = pct_lucru.Nr_Reg_Com;
                
            }
            SavePct.Text = "Update";
            DeletePct.Enabled = true;
        }

        private void dataGridViewPozitie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPozitie.CurrentCell.RowIndex != -1)
            {
                id_pozitie = Convert.ToInt32(dataGridViewPozitie.CurrentRow.Cells["pozitieangajatidDataGridViewTextBoxColumn"].Value);
                pozitie = db.pozitie_angajat.Where(x => x.pozitie_angajat_id == id_pozitie).FirstOrDefault();
                PosTxt.Text = pozitie.pozitie;
            }
            AddPozitie.Text = "Update";
            DeletePozitie.Enabled = true;
        }

        private void SaveAngajat_Click(object sender, EventArgs e)
        {
            if (EndContractPicker.Checked)
            {
                employee.DataIncheiereContract = EndContractPicker.Value;
            }
            else
            {
                employee.DataIncheiereContract = null;
            }
            if (StatusCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o valoare pentru campul Status.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employee.Nume = NameEmplTxt.Text.Trim();
            employee.Prenume = PNameEmplTxt.Text.Trim();
            employee.DataNasterii = DateTime.Parse(BirthDatePicker.Text.Trim());
            employee.Adresa = AdressEmplTxt.Text.Trim();
            employee.CNP = CnpEmplTxt.Text.Trim();
            employee.DataAngajarii = DateTime.Parse(HireDateTimePicker.Text.Trim());
            employee.Id_Pozitie_Angajat = Convert.ToInt32(PosCombo.SelectedValue);
            employee.IdPunctDeLucru = Convert.ToInt32(PctLucruCombo.SelectedValue);
            employee.Parola = PasswordTxt.Text.Trim();
            employee.Status = (StatusCombo.SelectedItem.ToString() == "Activ") ? true : false;
            if (id_angajat > 0)
                db.Entry(employee).State = EntityState.Modified;
            else
            {
                db.Angajats.Add(employee);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = NameEmplTxt, FieldName = "Nume", MaxLength = 50 },
        new FieldInfo { TextBox = PNameEmplTxt, FieldName = "Prenume", MaxLength = 50 },
        new FieldInfo { TextBox = PasswordTxt, FieldName = "Parola", MaxLength = 13 },
        new FieldInfo { TextBox = CnpEmplTxt, FieldName = "CNP", MaxLength = 13 },
        new FieldInfo { TextBox = AdressEmplTxt, FieldName = "Adresa ", MaxLength = 100 },
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
                ClearDataAngajat();
                SetDataInGridViewEmploy();
                MessageBox.Show("Inregistrare salvata cu succes");

        }

        private void DeleteAngajat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Angajats.Remove(employee);
                db.SaveChanges();
                ClearDataAngajat();
                SetDataInGridViewEmploy();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void CancelAngajat_Click(object sender, EventArgs e)
        {
            ClearDataAngajat();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            {
                string searchValue = Search.Text;
                AngajatdataGridView.ClearSelection();
                AngajatdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in AngajatdataGridView.Rows)
                    {
                        if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
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
    }
}

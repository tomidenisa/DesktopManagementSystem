using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDOP2
{
    public partial class Vehicul : Form
    {
        public Vehicul()
        {
            InitializeComponent();
        }

        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        vehicul vehicul = new vehicul();
        int id_vehicul = 0;
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

        private void Vehicul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.serviceAutoDBDataSet.Client);
            // TODO: This line of code loads data into the 'serviceAutoDBDataSet.vehicul' table. You can move, or remove it, as needed.
            this.vehiculTableAdapter.Fill(this.serviceAutoDBDataSet.vehicul);
            this.WindowState = FormWindowState.Maximized;
            SetDataInGridViewVehicul();
            ClearDataVehicul();

        }
        public void SetDataInGridViewVehicul()
        {
            VehiculdataGridView.AutoGenerateColumns = false;
            VehiculdataGridView.DataSource = db.vehiculs.ToList<vehicul>();
            tipvehiculcombo.SelectedIndex = -1;
            ClientCombo.SelectedIndex = -1;
        }
        public void ClearDataVehicul()
        {
           InmatriculareTxt.Text = DetaliiTxt.Text = ProducatorTextBox.Text = FabricatieTxt.Text = SasiuTxt.Text = string.Empty;
            DeleteVehicul.Enabled = true;
            AddVehicul.Text = "Salveaza";
            id_vehicul = 0;
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = Search.Text;
            VehiculdataGridView.ClearSelection();
            VehiculdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in VehiculdataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    row.Cells[9].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
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

        private void VehiculdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VehiculdataGridView.CurrentCell.RowIndex != -1)
            {
                id_vehicul = Convert.ToInt32(VehiculdataGridView.CurrentRow.Cells["idvehicul"].Value);
                vehicul = db.vehiculs.Where(x => x.id == id_vehicul).FirstOrDefault();
                SasiuTxt.Text = vehicul.serie_sasiu;
                InmatriculareTxt.Text = vehicul.nr_inmatriculare;
                FabricatieTxt.Text = Convert.ToString(vehicul.an_fabricatie);
                DetaliiTxt.Text = vehicul.detalii;
                ProducatorTextBox.Text = vehicul.producator;
                tipvehiculcombo.SelectedItem = vehicul.tip_vehicul;
                ClientCombo.SelectedValue = VehiculdataGridView.CurrentRow.Cells["idclient"].Value;
                ModelTxt.Text = vehicul.model;

            }
            AddVehicul.Text = "Update";
            DeleteVehicul.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientContact client = new ClientContact();
            client.Show();
        }

        private void CancelVehicul_Click(object sender, EventArgs e)
        {
            ClearDataVehicul();
        }

        private void DeleteVehicul_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.vehiculs.Remove(vehicul);
                db.SaveChanges();
                ClearDataVehicul();
                SetDataInGridViewVehicul();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }
        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
            public bool Required { get; set; }
        }

        private void AddVehicul_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(FabricatieTxt.Text.Trim(), out int anFabricatie))
            {
                MessageBox.Show("An fabricatie invalid. Introduceti un numar intreg.");
                errorProvider1.SetError(FabricatieTxt, "Introduceti un numar intreg");
                FabricatieTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(SasiuTxt.Text.Trim()))
            {
                MessageBox.Show("Serie Sasiu inexistenta. Introduceti seria de sasiu.");
                errorProvider1.SetError(SasiuTxt, "Introduceti seria de sasiu");
                SasiuTxt.Focus();
                return;
            }
            if (tipvehiculcombo.SelectedItem == null)
            {
                MessageBox.Show("Selectati un tip de vehicul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClientCombo.SelectedItem == null)
            {
                MessageBox.Show("Selectati un client.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            vehicul.data_inregistrare = DateTime.Now;
            vehicul.serie_sasiu = SasiuTxt.Text.Trim();
            vehicul.detalii = DetaliiTxt.Text.Trim();
            vehicul.producator = ProducatorTextBox.Text.Trim();
            vehicul.an_fabricatie = anFabricatie;
            vehicul.tip_vehicul = tipvehiculcombo.SelectedItem.ToString();
            vehicul.id_client = (int)ClientCombo.SelectedValue;
            vehicul.model = ModelTxt.Text.Trim();
            vehicul.nr_inmatriculare = InmatriculareTxt.Text.Trim();
            if (id_vehicul>0)
                db.Entry(vehicul).State = EntityState.Modified;
            else
            {
                db.vehiculs.Add(vehicul);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = SasiuTxt, FieldName = "Serie Sasiu", MaxLength = 50},
        new FieldInfo { TextBox = DetaliiTxt, FieldName = "Detalii", MaxLength = 200 },
        new FieldInfo { TextBox = ProducatorTextBox, FieldName = "Producator", MaxLength = 50 },
        new FieldInfo { TextBox = ModelTxt, FieldName = "Serie Sasiu", MaxLength = 50 },
        new FieldInfo { TextBox = FabricatieTxt, FieldName = "An fabricatie", MaxLength = 4 },
        new FieldInfo { TextBox = SasiuTxt, FieldName = "Serie Sasiu", MaxLength = 50 },
         new FieldInfo { TextBox = InmatriculareTxt, FieldName = "Nr Inmatriculare ", MaxLength = 10 },
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
            ClearDataVehicul();
            SetDataInGridViewVehicul();
            MessageBox.Show("Inregistrare salvata cu succes");
        }
    }
    
}


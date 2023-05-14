using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Vehicul vehicul1 = new Vehicul();
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
        }
        public void ClearDataVehicul()
        {
           InmatriculareTxt.Text = DetaliiTxt.Text = ProducatorTextBox.Text = FabricatieTxt.Text = SasiuTxt.Text = string.Empty;
            DeleteVehicul.Enabled = true;
            AddVehicul.Text = "Salveaza";
            id_vehicul = 0;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Search.Text = string.Empty;
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
                SasiuTxt.Text = vehicu
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
    }
    }


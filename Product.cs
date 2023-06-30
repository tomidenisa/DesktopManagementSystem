using CRUDOP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDOP2.Registration;

namespace CRUDOP2
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        produ produse = new produ();
        int Prod_id = 0;
        private void Product_Load(object sender, EventArgs e)
        {
            
            ClearData();
            SetDataInGridView();
            this.WindowState = FormWindowState.Maximized;
            Delete.Enabled = false;
            UserRole currentUserRole = UserManager.CurrentUserRole;
            if (currentUserRole == UserRole.User)
            {
                AdminButton.Visible = false;
                Add.Visible = false;
                Delete.Visible = false;
            }

        }
        public void ClearData()
        {
            NameTxt.Text = SerialTxt.Text = OriginalAftermarkt.Text = CompatTxt.Text = DescTxt.Text = BuyTxt.Text = Sellltxt.Text = Discountxt.Text= string.Empty;
            Delete.Enabled = true;
            Add.Text = "Salveaza";
            Prod_id = 0;
        }
        public void SetDataInGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = db.produs.ToList<produ>();
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
        class FieldInfo
        {
            public System.Windows.Forms.TextBox TextBox { get; set; }
            public string FieldName { get; set; }
            public int MaxLength { get; set; }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(BuyTxt.Text.Trim(), out decimal cost_achizitie))
            {
                produse.cost_achizitie = cost_achizitie;
            }
            else
            {

                MessageBox.Show("Introdu o valoare numerica in campul Cost Achizitie");
                return;
            }

            if (decimal.TryParse(Sellltxt.Text.Trim(), out decimal cost_vanzare))
            {
                produse.cost_vanzare = cost_vanzare;
            }
            else
            {

                MessageBox.Show("Introdu o valoare numerica in campul Cost Vanzare");
                return;
            }
            if (int.TryParse(Discountxt.Text.Trim(), out int discount))
            {
                produse.discount_maxim = discount;
            }
            else
            {

                MessageBox.Show("Introdu o valoare numerica in campul Discount");
                return;
            }
            produse.denumire = NameTxt.Text.Trim();
            produse.serie = SerialTxt.Text.Trim();
            produse.original_sau_aftermarket = OriginalAftermarkt.Text.Trim();
            produse.compatibilitate = CompatTxt.Text.Trim();
            produse.descriere = DescTxt.Text.Trim();
            produse.cost_achizitie = cost_achizitie;
            produse.cost_vanzare = cost_vanzare;
            produse.discount_maxim = discount;
            if (Prod_id > 0)
                db.Entry(produse).State = EntityState.Modified;
            else
            {
                db.produs.Add(produse);
            }
            List<FieldInfo> fields = new List<FieldInfo>
    {
        new FieldInfo { TextBox = NameTxt, FieldName = "Denumire", MaxLength = 50 },
        new FieldInfo { TextBox = SerialTxt, FieldName = "Serie", MaxLength = 50 },
        new FieldInfo { TextBox = CompatTxt, FieldName = "Compatibilitate", MaxLength = 35 },
        new FieldInfo { TextBox = BuyTxt, FieldName = "Cost Achizitie", MaxLength = 10 },
        new FieldInfo { TextBox = Sellltxt, FieldName = "Cost Vanare", MaxLength = 10 },
        new FieldInfo { TextBox = DescTxt, FieldName = "Descriere", MaxLength = 100 },
        new FieldInfo { TextBox = Discountxt, FieldName = "Discount", MaxLength = 10 }
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
            ClearData();
            SetDataInGridView();
            MessageBox.Show("Inregistrare salvata cu succes");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                db.produs.Remove(produse); 
                db.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            {
                string searchValue = Search.Text;
                dataGridView.ClearSelection();
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = true;
                    foreach (DataGridViewRow row in dataGridView.Rows)
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView.CurrentCell.RowIndex != -1)
            {
                Prod_id = Convert.ToInt32(dataGridView.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                produse = db.produs.Where(x => x.id == Prod_id).FirstOrDefault();
                NameTxt.Text = produse.denumire;
                SerialTxt.Text = produse.serie;
                CompatTxt.Text = produse.compatibilitate;
                OriginalAftermarkt.Text = produse.original_sau_aftermarket;
                DescTxt.Text = produse.descriere;
                BuyTxt.Text = produse.cost_achizitie.ToString();
                Sellltxt.Text = produse.cost_vanzare.ToString();
                Discountxt.Text = produse.discount_maxim.ToString();
            }
            Add.Text = "Update";
            Delete.Enabled = true;
        }

        private void SearchBtnInt_Click(object sender, EventArgs e)
        {
            string url = "https://www.webcat-solutions.com/ro/portal/loginNew.aspx?14=21";
            string username = "ademar";
            string password = "suiram1234";

            string args = $"--new-window --app={url} --disable-extensions --disable-plugins-discovery --disable-popup-blocking --bwsi --no-first-run --disable-background-timer-throttling --disable-renderer-backgrounding --disable-web-security --allow-running-insecure-content --disable-dev-shm-usage --no-sandbox --disable-gpu --no-proxy-server --proxy-auto-detect --proxy-bypass-list=127.0.0.1,localhost --proxy-server=127.0.0.1:8080 --disable-translate --password-store=basic --disable-logging --user-agent='Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36'";

            Process process = new Process();
            process.StartInfo.FileName = "chrome.exe";
            process.StartInfo.Arguments = args;
            process.Start();

            process.WaitForExit();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex != -1)
            {
                Prod_id = Convert.ToInt32(dataGridView.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                produse = db.produs.Where(x => x.id == Prod_id).FirstOrDefault();
                NameTxt.Text = produse.denumire;
                SerialTxt.Text = produse.serie;
                CompatTxt.Text = produse.compatibilitate;
                OriginalAftermarkt.Text = produse.original_sau_aftermarket;
                DescTxt.Text = produse.descriere;
                BuyTxt.Text = produse.cost_achizitie.ToString();
                Sellltxt.Text = produse.cost_vanzare.ToString();
                Discountxt.Text = produse.discount_maxim.ToString();
            }
            Add.Text = "Update";
            Delete.Enabled = true;
        }
    }
}

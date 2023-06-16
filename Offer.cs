using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Licensing;
using static CRUDOP2.Registration;

namespace CRUDOP2
{
    public partial class Offer : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";
        private int currentNr = 1;
        private decimal totalValue = 0;
        public Offer()
        {
            InitializeComponent();
        }

        private void Offer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UserRole currentUserRole = UserManager.CurrentUserRole;
            SetDataInMateriale();
            SetDataInProgramariCombo();
            vehiculComboBox.Enabled = false;
            totalTxt.ReadOnly = true;

        }
        private string GetUniqueFilePath()
        {
            string fileName = "Offer_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            string filePath = Path.Combine(@"C:\Users\denit\Desktop", fileName);
            return filePath;
        }


        private void SetDataInProgramariCombo()
        {
            bool hasProgramare = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id FROM programare WHERE angajat_id = @UserID AND status != 'In Asteptare'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUserID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int appointmentID = reader.GetInt32(0);
                        programareComboBox.Items.Add(appointmentID);
                        hasProgramare = true; // Set the flag to true if at least one programare entry is found
                    }

                    connection.Close();

                    if (!hasProgramare)
                    {
                        MessageBox.Show("Nu există programări active pentru care poți completa ofertare.", "No Programare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        programareComboBox.Enabled = false;
                        vehiculComboBox.Enabled = false;
                        AddCantitate.Enabled = false;
                    }
                }
            }
        }
        private void programareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            vehiculComboBox.Items.Clear();


            if (programareComboBox.SelectedIndex != -1)
            {

                int programareID = (int)programareComboBox.SelectedItem;


                int clientID;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Client_Id FROM contact WHERE Programare_Id = @ProgramareID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProgramareID", programareID);
                        clientID = (int)command.ExecuteScalar();
                    }
                    connection.Close();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT serie_sasiu FROM vehicul WHERE id_client = @ClientID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientID);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string serieSasiu = reader.GetString(0);
                            vehiculComboBox.Items.Add(serieSasiu);
                        }
                    }
                    connection.Close();
                }
            }

            // Enable the vehiculComboBox
            vehiculComboBox.Enabled = true;
        }


        private void SetDataInMateriale()
        {
            string query = "SELECT 'Serviciu' AS Tip, catalog_servicii.denumire, SUM(catalog_tip_reparatie.pret) AS Pret " +
                           "FROM catalog_servicii " +
                           "INNER JOIN catalog_tip_reparatie ON catalog_servicii.id = catalog_tip_reparatie.id_catalog_servicii " +
                           "GROUP BY catalog_servicii.denumire " +
                           "UNION " +
                           "SELECT 'Produs' AS Tip, produs.denumire, produs.cost_vanzare AS Pret " +
                           "FROM produs";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridViewMateriale.DataSource = dataTable;
                }
            }
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

        private void PrdctName_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;


            if (selectedDate == DateTime.MinValue)
            {
                MessageBox.Show("Selecteaza data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void AddCantitate_Click(object sender, EventArgs e)
        {
            if (programareComboBox.SelectedIndex != -1)
            {
                if (dataGridViewMateriale.SelectedRows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(cantitateTxt.Text))
                    {
                        // Check if cantitateTxt contains a valid integer value
                        if (int.TryParse(cantitateTxt.Text, out int quantity))
                        {
                            // Get the selected row
                            DataGridViewRow selectedRow = dataGridViewMateriale.SelectedRows[0];

                            // Extract the necessary values from the selected row
                            string tip = selectedRow.Cells["Tip"].Value.ToString();
                            string denumire = selectedRow.Cells["Denumire"].Value.ToString();
                            decimal pret = decimal.Parse(selectedRow.Cells["Pret"].Value.ToString());
                            int cantitate = int.Parse(cantitateTxt.Text);


                            dataGridViewOferta.Rows.Add(currentNr, tip, cantitate, denumire, pret);


                            currentNr++;


                            decimal lineTotal = pret * cantitate;
                            totalValue += lineTotal;


                            totalTxt.Text = totalValue.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantitate must be a valid integer.", "Invalid Cantitate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value for Cantitate.", "Empty Cantitate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a line from the dataGridViewMateriale.", "No Line Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a programare.", "No Programare Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }
        private void GeneratePDF()
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a page to the document
            PdfPage page = document.Pages.Add();

            // Create PDF graphics
            PdfGraphics graphics = page.Graphics;

            // Set the font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            // Set the initial y-coordinate for drawing content
            float y = 50;

            // Draw the date
            DateTime selectedDate = dateTimePicker1.Value;
            string dateString = selectedDate.ToString("dd/MM/yyyy");
            graphics.DrawString("Date: " + dateString, font, PdfBrushes.Black, new PointF(50, y));
            y += 20;

            // Draw the programare ID
            int programareID = (int)programareComboBox.SelectedItem;
            graphics.DrawString("Programare ID: " + programareID.ToString(), font, PdfBrushes.Black, new PointF(50, y));
            y += 20;

            // Draw the vehicul serie sasiu
            string serieSasiu = vehiculComboBox.SelectedItem?.ToString();
            graphics.DrawString("Vehicul Serie Sasiu: " + serieSasiu, font, PdfBrushes.Black, new PointF(50, y));
            y += 40;

            // Draw the "Denumire Materiale" text
            graphics.DrawString("Denumire Materiale", font, PdfBrushes.Black, new PointF(50, y));
            y += 20;

            // Create a table for dataGridViewOferta data
            PdfGrid table = new PdfGrid();
            table.Style.Font = font;
            table.Style.CellPadding.All = 5;

            // Set the number of columns
            table.Columns.Add(5);

            // Add the headers to the table
            PdfGridRow headerRow = table.Headers.Add(1)[0];
            headerRow.Cells[0].Value = "Nr";
            headerRow.Cells[1].Value = "Tip";
            headerRow.Cells[2].Value = "Cantitate";
            headerRow.Cells[3].Value = "Denumire";
            headerRow.Cells[4].Value = "Pret";

            // Set border style for header cells
            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(PdfBrushes.Black, 0.5f);
            headerRow.Cells[0].Style = headerStyle;
            headerRow.Cells[1].Style = headerStyle;
            headerRow.Cells[2].Style = headerStyle;
            headerRow.Cells[3].Style = headerStyle;
            headerRow.Cells[4].Style = headerStyle;

            // Add the data rows to the table
            foreach (DataGridViewRow dataGridViewRow in dataGridViewOferta.Rows)
            {
                // Skip the new row for entering data
                if (!dataGridViewRow.IsNewRow)
                {
                    // Create a new row in the PDF table
                    PdfGridRow pdfGridRow = table.Rows.Add();

                    // Set the values of each cell in the PDF table row
                    pdfGridRow.Cells[0].Value = dataGridViewRow.Cells[0].Value?.ToString();
                    pdfGridRow.Cells[1].Value = dataGridViewRow.Cells[1].Value?.ToString();
                    pdfGridRow.Cells[2].Value = dataGridViewRow.Cells[2].Value?.ToString();
                    pdfGridRow.Cells[3].Value = dataGridViewRow.Cells[3].Value?.ToString();
                    pdfGridRow.Cells[4].Value = dataGridViewRow.Cells[4].Value?.ToString();
                }
            }

            // Draw the table on the PDF page
            table.Draw(page, new PointF(50, y));

            // Calculate the total height of the table, including the header row and all data rows
            float tableHeight = table.Rows.Sum(row => row.Height) + table.Headers[0].Height;

            // Calculate the bottom edge of the table
            float tableBottomY = y + tableHeight;

            // Update the y-coordinate for drawing the "Total" text
            float totalTextY = tableBottomY + 20; // Add some additional spacing below the table

            // Draw the "Total" text and value
            string totalText = "Total: " + totalTxt.Text;
            float totalTextWidth = font.MeasureString(totalText).Width;
            float totalTextX = page.GetClientSize().Width - totalTextWidth - 50;
            PointF totalTextPosition = new PointF(totalTextX, totalTextY);
            graphics.DrawString(totalText, font, PdfBrushes.Black, totalTextPosition);



            // Save the document
            string filePath = GetUniqueFilePath();
            document.Save(filePath);

            // Close the document
            document.Close();

            MessageBox.Show("Oferta generata cu succes.", "Generare oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

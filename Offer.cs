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
using System.Net.Mail;
using System.Net;
using Google.Apis.Gmail.v1.Data;
using MimeKit;
using System.IO;
using System.Text;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis;
using Google.Apis.Services;
using Google.Apis.Gmail;
using static CRUDOP2.Registration;
using Google.Apis.Gmail.v1;
using Google.Apis.Auth.OAuth2.Responses;
using System.Threading;
using Google.Apis.Auth.OAuth2.Flows;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using RabbitMQ.Client;

namespace CRUDOP2
{

    public partial class Offer : Form
    {
        MailMessage mesaj;
        SmtpClient smtp;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";
        private int currentNr = 1;
        private decimal totalValue = 0;
        private int Timp1 = 0;
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
            timpTxt.ReadOnly = true;

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
            string query = "SELECT 'Serviciu' AS Tip, catalog_servicii.denumire, SUM(catalog_tip_reparatie.pret) AS Pret, SUM(catalog_tip_reparatie.timp_necesar_max) AS Timp " +
                           "FROM catalog_servicii " +
                           "INNER JOIN catalog_tip_reparatie ON catalog_servicii.id = catalog_tip_reparatie.id_catalog_servicii " +
                           "GROUP BY catalog_servicii.denumire " +
                           "UNION " +
                           "SELECT 'Produs' AS Tip, produs.denumire, produs.cost_vanzare AS Pret, 0 AS Timp " +
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
                            int Timpcol = int.Parse(selectedRow.Cells["Timp"].Value.ToString());


                            dataGridViewOferta.Rows.Add(currentNr, tip, cantitate, denumire, pret, Timpcol);


                            currentNr++;

                            int timptot = cantitate * Timpcol;
                            Timp1 += timptot;

                            decimal lineTotal = pret * cantitate;
                            totalValue += lineTotal;


                            totalTxt.Text = totalValue.ToString();
                            timpTxt.Text = Timp1.ToString();
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
        private DataTable GetAngajatDataFromDatabase(int userId)
        {
            string query = "SELECT Angajat.*, Punct_Lucru_Service.* " +
                           "FROM Angajat " +
                           "INNER JOIN Punct_Lucru_Service ON angajat.IdPunctDeLucru = Punct_Lucru_Service.Punct_Lucru_Id " +
                           "WHERE Angajat.Id = @userId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    return dataTable;
                }
            }
        }
        public string GetAngajatNameFromDatabase(int userId)
        {
            // Assuming you are using a database connection named "connection"
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SQL command to fetch the angajat name based on the user ID
                string query = "SELECT CONCAT(Nume, ' ', Prenume) AS NumeComplet FROM Angajat WHERE Id = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    // Execute the query and retrieve the angajat name
                    string angajatName = command.ExecuteScalar()?.ToString();

                    return angajatName;
                }
            }
        }


        private void SendEmailWithAttachment(string fromEmail, string toEmail, string subject, string body, string attachmentFilePath)
        {
            // Configure the SMTP client
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com", 
                Port = 587, 
                EnableSsl = true, 
                Credentials = new NetworkCredential(fromEmail, "gmajvhmnijdtjlnf") 
            };

           
            var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body
            };

            
            if (!string.IsNullOrEmpty(attachmentFilePath))
            {
                var attachment = new Attachment(attachmentFilePath);
                message.Attachments.Add(attachment);
            }

            try
            {
                
                smtpClient.Send(message);
                MessageBox.Show("Notificare trimisa cu succes !", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trimitere esuata: " + ex.Message, "Email Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int userId = UserManager.CurrentUserID;
        private async void button2_Click(object sender, EventArgs e)
        {
            string angajatName = GetAngajatNameFromDatabase(userId);
            DateTime selectedDate = dateTimePicker1.Value;
            int programareID = (int)programareComboBox.SelectedItem;
            try
            {
                // Create a connection factory and establish a connection
                var factory = new ConnectionFactory()
                {
                    HostName = "localhost", // Change this to the hostname of your RabbitMQ server if it's not running locally
                    UserName = "guest", // Change this if you have a different username
                    Password = "guest" // Change this if you have a different password
                };

                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    // Declare a queue to send the message to
                    channel.QueueDeclare(queue: "administrator_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    // Construct the message body
                    string message = $"Angajatul {angajatName} a intocmit oferta pentru Programarea {programareID}";

                    // Convert the message to bytes
                    byte[] body = Encoding.UTF8.GetBytes(message);

                    // Publish the message to the queue
                    channel.BasicPublish(exchange: "", routingKey: "administrator_queue", basicProperties: null, body: body);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (programareComboBox.SelectedIndex == -1 || vehiculComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza o programare.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Selecteaza data.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (dataGridViewOferta.Rows.Count == 0)
            {
                MessageBox.Show("Adauga cel putin un produs sau serviciu la oferta.", "Empty Offer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            string filePath = GetUniqueFilePath();
            GeneratePDF();
            System.Threading.Thread.Sleep(5000);
            try
            {
                
                string fromEmail = "ademartomisender@gmail.com";
                string toEmail = "ademartomireciever@gmail.com";
                string subject = "Deviz Ofertare";
                string body = "Atasat regasiti oferta cu urmatoarele caracteristici .\n\n" +
              "Angajat : " + angajatName + "\n" +
              "Date: " + selectedDate.ToString("dd/MM/yyyy") + "\n" +
              "Programare ID: " + programareID.ToString();

                // Send the email
                SendEmailWithAttachment(fromEmail, toEmail, subject, body, filePath);
                MessageBox.Show("Oferta generata si trimisa cu succes.", "Generare si Trimitere Oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trimitere esuata a notificarii email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reset the form fields
            programareComboBox.SelectedIndex = -1;
            vehiculComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dataGridViewOferta.Rows.Clear();
            cantitateTxt.Text = string.Empty;
            totalTxt.Text = string.Empty;
            timpTxt.Text = string.Empty;
        }


        private string GetUniqueFilePath()
        {
            string angajatName = GetAngajatNameFromDatabase(userId);
            string currentTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = "Offer_" + angajatName + "_" + currentTime + ".pdf";
            string filePath = Path.Combine(@"C:\Users\denit\Desktop", fileName);
            return filePath;
        }
        private void  GeneratePDF()
        {
           
                // Create a new PDF document
                PdfDocument document = new PdfDocument();

            // Add a page to the document
            PdfPage page = document.Pages.Add();

            // Create PDF graphics
            PdfGraphics graphics = page.Graphics;

            


            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            
            float y = 50;

            
            int userId = UserManager.CurrentUserID; 
            DataTable angajatData = GetAngajatDataFromDatabase(userId);

            if (angajatData.Rows.Count > 0)
            {
                DataRow angajatRow = angajatData.Rows[0];

                
                string punctDeLucruName = angajatRow["Denumire"].ToString();
                string punctDeLucruAddress = angajatRow["Adresa"].ToString();
                string contbancar = angajatRow["Cont_Bancar"].ToString();
                string cif = angajatRow["CIF"].ToString();
                string regcom = angajatRow["Nr_Reg_Com"].ToString();

                
                graphics.DrawString("Punct de Lucru: " + punctDeLucruName, font, PdfBrushes.Black, new PointF(50, y));
                y += 20;

                graphics.DrawString("Adresa: " + punctDeLucruAddress, font, PdfBrushes.Black, new PointF(50, y));
                y += 20;

                graphics.DrawString("Cont Bancar: " + contbancar, font, PdfBrushes.Black, new PointF(50, y));
                y += 20;

                graphics.DrawString("CIF: " + cif, font, PdfBrushes.Black, new PointF(50, y));
                y += 20;

                graphics.DrawString("Nr. Reg. Com. : " + regcom, font, PdfBrushes.Black, new PointF(50, y));
                y += 20;

                y += 30; 
            }
           
            float pageWidth = page.GetClientSize().Width;

            
            string title = "Deviz Ofertare";
            float titleFontSize = 18;
            PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, titleFontSize, PdfFontStyle.Bold);
            float titleWidth = titleFont.MeasureString(title).Width;
            float titleX = (pageWidth - titleWidth) / 2; 
            graphics.DrawString(title, titleFont, PdfBrushes.Black, new PointF(titleX, y));
            y += 40;

            
            DateTime selectedDate = dateTimePicker1.Value;
            string dateString = selectedDate.ToString("dd/MM/yyyy");
            graphics.DrawString("Date: " + dateString, font, PdfBrushes.Black, new PointF(50, y));
            y += 30;

           
            int programareID = (int)programareComboBox.SelectedItem;
            graphics.DrawString("Cod Document: " + programareID.ToString(), font, PdfBrushes.Black, new PointF(50, y));
            y += 40;

            
            string serieSasiu = vehiculComboBox.SelectedItem?.ToString();
            float vehiculX = page.GetClientSize().Width - font.MeasureString("Vehicul Serie Sasiu: " + serieSasiu).Width - 50;
            graphics.DrawString("Vehicul Serie Sasiu: " + serieSasiu, font, PdfBrushes.Black, new PointF(vehiculX, y));
            y += 40;

           
            graphics.DrawString("Produse si Servicii", font, PdfBrushes.Black, new PointF(50, y));
            y += 20;

            
            PdfGrid table = new PdfGrid();
            table.Style.Font = font;
            table.Style.CellPadding.All = 5;

            
            table.Columns.Add(5);

           
            PdfGridRow headerRow = table.Headers.Add(1)[0];
            headerRow.Cells[0].Value = "Nr";
            headerRow.Cells[1].Value = "Tip";
            headerRow.Cells[2].Value = "Cantitate";
            headerRow.Cells[3].Value = "Denumire";
            headerRow.Cells[4].Value = "Pret";

           
            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(PdfBrushes.Black, 0.5f);
            headerRow.Cells[0].Style = headerStyle;
            headerRow.Cells[1].Style = headerStyle;
            headerRow.Cells[2].Style = headerStyle;
            headerRow.Cells[3].Style = headerStyle;
            headerRow.Cells[4].Style = headerStyle;

           
            foreach (DataGridViewRow dataGridViewRow in dataGridViewOferta.Rows)
            {
               
                if (!dataGridViewRow.IsNewRow)
                {
                    
                    PdfGridRow pdfGridRow = table.Rows.Add();

                    
                    pdfGridRow.Cells[0].Value = dataGridViewRow.Cells[0].Value?.ToString();
                    pdfGridRow.Cells[1].Value = dataGridViewRow.Cells[1].Value?.ToString();
                    pdfGridRow.Cells[2].Value = dataGridViewRow.Cells[2].Value?.ToString();
                    pdfGridRow.Cells[3].Value = dataGridViewRow.Cells[3].Value?.ToString();
                    pdfGridRow.Cells[4].Value = dataGridViewRow.Cells[4].Value?.ToString();
                }
            }

            
            table.Draw(page, new PointF(50, y));

           
            float tableHeight = table.Rows.Sum(row => row.Height) + table.Headers[0].Height;

            
            float tableBottomY = y + tableHeight;

            
            float totalTextY = tableBottomY + 20; 

           
            string totalText = "Total General Pret: " + totalTxt.Text;
            float totalTextWidth = font.MeasureString(totalText).Width;
            float totalTextX = page.GetClientSize().Width - totalTextWidth - 50;
            PointF totalTextPosition = new PointF(totalTextX, totalTextY);
            graphics.DrawString(totalText, font, PdfBrushes.Black, totalTextPosition);

            
            string totalTimpText = "Total Timp Necesar in ore: " + timpTxt.Text;
            graphics.DrawString(totalTimpText, font, PdfBrushes.Black, new PointF(50, totalTextY));

           
            string angajatName = GetAngajatNameFromDatabase(userId);

            string responsabilText = "Responsabil: " + angajatName;
            float responsabilX = 50;
            float responsabilY = totalTextY + 40; 
            graphics.DrawString(responsabilText, font, PdfBrushes.Black, new PointF(responsabilX, responsabilY));


            string semnaturaText = "Semnatura:";
            float semnaturaTextWidth = font.MeasureString(semnaturaText).Width;
            float semnaturaX = page.GetClientSize().Width - semnaturaTextWidth - 50;
            graphics.DrawString(semnaturaText, font, PdfBrushes.Black, new PointF(semnaturaX, responsabilY));

            string filePath = GetUniqueFilePath();
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    document.Save(fileStream);
                }
                MessageBox.Show("Oferta generata cu succes.", "Generare oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate the offer PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the document
            document.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Appointment appoin = new Appointment();
            appoin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            programareComboBox.SelectedIndex = -1;
            vehiculComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dataGridViewOferta.Rows.Clear();
            cantitateTxt.Text = string.Empty;
            totalTxt.Text = string.Empty;
            timpTxt.Text = string.Empty;
        }
    }
}

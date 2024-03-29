﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static CRUDOP2.Registration;

namespace CRUDOP2
{
    public partial class Home : Form
    {
        private UserRole userRole;
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";
        public Home()
        {
            InitializeComponent();
        }
        public void SetUserRole(UserRole role)
        {
            userRole = role;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UserRole currentUserRole = UserManager.CurrentUserRole;
            if (currentUserRole == UserRole.User)
            {
                navnotif.Visible = false;
                AdminButton.Visible= false;
            }
            if (currentUserRole == UserRole.Admin)
            {
                button4.Visible = false;
            }
            label1.BorderStyle = BorderStyle.Fixed3D;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label6.BorderStyle = BorderStyle.Fixed3D;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();


            label1.Font = new Font(label1.Font.FontFamily, 20, FontStyle.Bold);
            DisplayProgramariStatus();
            DisplayProgramariDistributionChart();
            PopulateChart();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        public void DisplayProgramariStatus()
        {
            int totalProgramari = GetTotalProgramari();
            int inAsteptareCount = GetProgramariStatus("In Asteptare");
            int inProgresCount = GetProgramariStatus("In Progres");
            int finalizatCount = GetProgramariStatus("Finalizat");
            int angajatCount = GetAngajatCount();


            label2.Text = totalProgramari.ToString();
            label3.Text = inAsteptareCount.ToString();
            label4.Text = inProgresCount.ToString();
            label5.Text = finalizatCount.ToString();
            label6.Text = angajatCount.ToString();

            Font boldFont = new Font(label2.Font.FontFamily, 20, FontStyle.Bold);
            label2.Font = boldFont;
            label3.Font = boldFont;
            label4.Font = boldFont;
            label5.Font = boldFont;
            label6.Font = boldFont;
        }
        public int GetTotalProgramari()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM programare";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }

        private void DisplayProgramariDistributionChart()
        {
            int totalCount = GetTotalProgramari();
            int inAsteptareCount = GetProgramariStatus("In Asteptare");
            int inProgresCount = GetProgramariStatus("In Progres");
            int finalizatCount = GetProgramariStatus("Finalizat");

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea");
            chart1.Series.Add("Programari");
            chart1.Series["Programari"].ChartType = SeriesChartType.Pie;
            chart1.Legends.Clear();

            chart1.Series["Programari"].Points.AddXY("In Asteptare", inAsteptareCount);
            chart1.Series["Programari"].Points.AddXY("In Progres", inProgresCount);
            chart1.Series["Programari"].Points.AddXY("Finalizat", finalizatCount);

            Color greenColor = ColorTranslator.FromHtml("#00FF00");
            Color redColor = ColorTranslator.FromHtml("#ff033d");
            Color blueColor = ColorTranslator.FromHtml("#4f03ff");

            chart1.Series["Programari"].Points[0].Color = redColor;    // In Asteptare
            chart1.Series["Programari"].Points[1].Color = blueColor;   // In Progres
            chart1.Series["Programari"].Points[2].Color = greenColor;  // Finalizat

            //Legend legend = new Legend();
            //chart1.Legends.Add(legend);

            //chart1.Series["Programari"].IsVisibleInLegend = true;
            //chart1.Series["Programari"].LegendText = "#LABEL";

            foreach (DataPoint dataPoint in chart1.Series["Programari"].Points)
            {
                double percentage = (dataPoint.YValues[0] / totalCount) * 100;
                dataPoint.Label = $"{percentage:F1}%";
               // dataPoint.LegendText = "";  
            }

            chart1.Invalidate();
        }
        private void PopulateChart()
        {
            // Clear any existing data in the chart
            chart2.Series.Clear();

            // Create a dictionary to store the department counters
            Dictionary<string, int> departmentCounters = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Query to retrieve the number of employees and position IDs
                string query = "SELECT Id_Pozitie_Angajat " +
                               "FROM Angajat " +
                               "WHERE Id_Pozitie_Angajat IN (2, 3, 4, 5, 7, 8, 10)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate over the retrieved data
                        while (reader.Read())
                        {
                            int positionId = reader.GetInt32(0);

                            // Get the department name based on the position ID
                            string department = GetDepartmentName(positionId);

                            // Check if the department already exists in the dictionary
                            if (departmentCounters.ContainsKey(department))
                            {
                                // Increment the counter for the department
                                departmentCounters[department]++;
                            }
                            else
                            {
                                // Add the department to the dictionary with an initial count of 1
                                departmentCounters.Add(department, 1);
                            }
                        }
                    }
                }

                // Create a single series for the bar chart
                Series series = chart2.Series.Add("Angajati");
                series.ChartType = SeriesChartType.Bar;

                // Set the color for each department
                series.Palette = ChartColorPalette.BrightPastel;

                // Add data points to the bar chart for each department
                foreach (var departmentCounter in departmentCounters)
                {
                    series.Points.AddXY(departmentCounter.Key, departmentCounter.Value);
                }
            }
        }

        private string GetDepartmentName(int positionId)
        {
            if (positionId >= 2 && positionId <= 7)
                return "Atelier";
            else if (positionId == 8)
                return "Financiar-Contabil";
            else if (positionId == 10)
                return "Administratie";
            else
                return "Unknown";
        }








        public int GetProgramariStatus(string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM programare WHERE status = @Status";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }
        public int GetAngajatCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Angajat";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
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

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home formhomp = new Home();
            formhomp.Show();
        }

        private void AddCantitate_Click(object sender, EventArgs e)
        {
            Notification notif = new Notification();
            notif.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotificationEmpl ntf = new NotificationEmpl();
            this.Hide();
            ntf.Show();
        }
    }
}

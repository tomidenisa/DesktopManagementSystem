using System;
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
            // Customize the behavior of the form based on the user role
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UserRole currentUserRole = UserManager.CurrentUserRole;
            if (currentUserRole == UserRole.User)
            {
                AddCantitate.Enabled = false;
            }
            label1.BorderStyle = BorderStyle.Fixed3D;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label6.BorderStyle = BorderStyle.Fixed3D;
            // Start a timer to update the date and time every second
            Timer timer = new Timer();
            timer.Interval = 1000; // Update every 1 second (1000 milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();


            // Set the font to be big and bold
            label1.Font = new Font(label1.Font.FontFamily, 20, FontStyle.Bold);
            DisplayProgramariStatus();
            DisplayProgramariDistributionChart();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label text with the current date and time
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
            // Retrieve the counts of programari for each status category from the database
            int totalCount = GetTotalProgramari();
            int inAsteptareCount = GetProgramariStatus("In Asteptare");
            int inProgresCount = GetProgramariStatus("In Progres");
            int finalizatCount = GetProgramariStatus("Finalizat");

            // Configure the chart control
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea");
            chart1.Series.Add("Programari");
            chart1.Series["Programari"].ChartType = SeriesChartType.Pie;
            chart1.Legends.Clear();

            // Add data points to the chart
            chart1.Series["Programari"].Points.AddXY("In Asteptare", inAsteptareCount);
            chart1.Series["Programari"].Points.AddXY("In Progres", inProgresCount);
            chart1.Series["Programari"].Points.AddXY("Finalizat", finalizatCount);

            Color greenColor = ColorTranslator.FromHtml("#00FF00");
            Color redColor = ColorTranslator.FromHtml("#ff033d");
            Color blueColor = ColorTranslator.FromHtml("#4f03ff");

            // Assign colors to each data point
            chart1.Series["Programari"].Points[0].Color = redColor;    // In Asteptare
            chart1.Series["Programari"].Points[1].Color = blueColor;   // In Progres
            chart1.Series["Programari"].Points[2].Color = greenColor;  // Finalizat

            // Add a legend control to the chart
            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            // Set the legend text
            chart1.Series["Programari"].IsVisibleInLegend = true;
            chart1.Series["Programari"].LegendText = "#LABEL";

            // Set the data point labels as percentages
            foreach (DataPoint dataPoint in chart1.Series["Programari"].Points)
            {
                double percentage = (dataPoint.YValues[0] / totalCount) * 100;
                dataPoint.Label = $"{percentage:F1}%";
                dataPoint.LegendText = "";  // Remove legend text for data points
            }

            // Refresh the chart display
            chart1.Invalidate();
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
    }
}

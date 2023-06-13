using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Web.UI.HtmlControls;

namespace CRUDOP2
{
    public partial class Registration : Form
    {

        public enum UserRole
        {
            Admin,
            User
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
          
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";
            string username = usertxt.Text;
            string password = passwordtxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id_Pozitie_Angajat FROM Angajat WHERE CNP = @CNP AND Parola = @Parola";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CNP", username);
                    command.Parameters.AddWithValue("@Parola", password);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null)
                    {
                        int idPozitie = Convert.ToInt32(result);


                        Home homeForm = new Home();
                        homeForm.SetUserRole(idPozitie == 8 || idPozitie == 10 ? UserRole.Admin : UserRole.User);
                        homeForm.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }

        }
    }
}

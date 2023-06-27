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
using System.Security.Cryptography;

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
            string connectionString = DataBaseConnection.ConnectionString;
            string username = usertxt.Text;
            string password = passwordtxt.Text;

            using (SqlConnection connection = DataBaseConnection.GetConnection())
            {
                string query = "SELECT Id_Pozitie_Angajat, Id, Parola FROM Angajat WHERE CNP = @CNP";
                using (SqlCommand command = DataBaseConnection.CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CNP", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int idPozitie = reader.GetInt32(0);
                        int userID = reader.GetInt32(1);
                        string storedPassword = reader.GetString(2);

                        bool isPasswordCorrect = false;

                        if (IsPasswordHashed(storedPassword))
                        {
                            isPasswordCorrect = VerifyHashedPassword(password, storedPassword);
                        }
                        else
                        {
                            isPasswordCorrect = (password == storedPassword);
                        }

                        if (isPasswordCorrect)
                        {
                            UserManager.CurrentUserID = userID;
                            UserManager.CurrentUserRole = (idPozitie == 8 || idPozitie == 10) ? UserRole.Admin : UserRole.User;

                            Home homeForm = new Home();
                            homeForm.SetUserRole(UserManager.CurrentUserRole);
                            homeForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Parola invalida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username invalid");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private bool IsPasswordHashed(string password)
        {
            return password.Length == 50; 
        }

        private bool VerifyHashedPassword(string password, string hashedPassword)
        {
            if (IsPasswordHashed(hashedPassword))
            {
                
                return hashedPassword == HashPassword(password);
            }
            else
            {
                return HashPassword(password) == hashedPassword;
            }
        }

        private string HashPassword(string password)
        {
           
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length && i < 32; i++) 
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString().Substring(0, Math.Min(builder.Length, 50)); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass pass = new ChangePass();
            pass.Show();
            this.Hide();
        }
    }
}

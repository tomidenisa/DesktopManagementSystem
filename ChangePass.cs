using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration formreg = new Registration();
            formreg.Show();
            this.Hide();
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

        private void savenewpass_Click(object sender, EventArgs e)
        {
            string cnp = cnpTxt.Text.Trim();
            string newHashedPassword = HashPassword(parolaNouaTxt.Text.Trim());

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Angajat SET Parola = @NewHashedPassword WHERE CNP = @CNP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewHashedPassword", newHashedPassword);
                    command.Parameters.AddWithValue("@CNP", cnp);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Parola a fost schimbata cu succes!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a gasit un angajat cu CNP-ul specificat!");
                    }
                }
            }
            Registration form= new Registration();
            form.Show();
            this.Hide();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}

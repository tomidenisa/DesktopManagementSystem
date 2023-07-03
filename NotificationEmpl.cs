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

namespace CRUDOP2
{
    public partial class NotificationEmpl : Form
    {
        public NotificationEmpl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.Show();
        }
        private Consumer consumer;
        private RabbitMQSender _client;
        private void CreateReadClient()
        {
            if (_client == null)
                _client = CreateClient();
        }
        private RabbitMQSender CreateClient()
        {
            return new RabbitMQSender();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                CreateReadClient();
                var messages = _client.ReadAll("administrator_queue", "admin2");
                string allMessages = string.Join(Environment.NewLine, messages);
                rtbMessages.Text = allMessages;
                _client.Rollback();
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotificationEmpl_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

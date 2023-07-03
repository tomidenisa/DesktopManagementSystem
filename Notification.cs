using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Controls;
using CRUDOP2.Models;

namespace CRUDOP2
{
    public partial class Notification : Form
    {
        private Consumer consumer;
        public Notification()
        {
            InitializeComponent();
        }
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
        private async void Notification_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Console.WriteLine("Notification form loaded.");
         
        }

        public async Task GetMessages()
        {
            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = "localhost",
                    UserName = "guest",
                    Password = "guest"
                };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "administrator_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    var consumer = new AsyncEventingBasicConsumer(channel);
                    channel.BasicConsume(queue: "administrator_queue", autoAck: true, consumer: consumer);
                    consumer.Received += async (eventSender, eventArgs) =>
                    {
                        var message = Encoding.UTF8.GetString(eventArgs.Body.ToArray());
                        var currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        await Task.Run(() =>
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                rtbMessages.AppendText($"{currentDate}: {message}\n");
                            });
                        });

                        Console.WriteLine($"Received message: {currentDate}: {message}");
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LOGIN_Click_1(object sender, EventArgs e)
        {
            try
            {
                CreateReadClient();
                var messages = _client.ReadAll("administrator", "admin1");
                string allMessages = string.Join(Environment.NewLine, messages);
                rtbMessages.Text = allMessages;
                _client.Rollback();
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home formh = new Home();
            this.Hide();
            formh.Show();
        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

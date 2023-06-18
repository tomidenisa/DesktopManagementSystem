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

namespace CRUDOP2
{
    public partial class Notification : Form
    {
        private DataTable messageTable;
        private BindingSource messageBindingSource;

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Notification form loaded.");
            messageTable = new DataTable();
            messageTable.Columns.Add("Date", typeof(string));
            messageTable.Columns.Add("Message", typeof(string));

            // Add a test message directly to the DataTable
            messageTable.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "Test Message");

            messageBindingSource = new BindingSource();
            messageBindingSource.DataSource = messageTable;

            notifications.DataSource = messageBindingSource;
            notifications.AutoResizeColumns();

        }

        public void GetMessages()
        {
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
                    // Declare a queue to receive the messages from
                    channel.QueueDeclare(queue: "administrator_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    // Create a consumer and wire up the event handler for received messages
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (eventSender, eventArgs) =>
                    {
                        // Convert the received message to a string
                        var message = Encoding.UTF8.GetString(eventArgs.Body.ToArray());

                        // Get the current date and time
                        var currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        // Add the message and date to the DataTable
                        BeginInvoke((MethodInvoker)delegate
                        {
                            messageTable.Rows.Add(currentDate, message);
                            notifications.Update();
                            messageBindingSource.ResetBindings(false);
                        });

                        // Log the received message for debugging
                        Console.WriteLine($"Received message: {currentDate}: {message}");
                    };

                    // Start consuming messages from the queue
                    channel.BasicConsume(queue: "administrator_queue", autoAck: true, consumer: consumer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddCantitate_Click(object sender, EventArgs e)
        {
            await Task.Run(() => GetMessages());
        }
    }
}

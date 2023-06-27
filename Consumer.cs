using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public class Consumer
    {
        private ConnectionFactory factory;
        private IConnection connection;
        private IModel channel;
        private RichTextBox richTextBox;

        public Consumer(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public async Task StartConsuming()
        {
            try
            {
                factory = new ConnectionFactory()
                {
                    HostName = "localhost",
                    UserName = "guest",
                    Password = "guest"
                };
                connection = factory.CreateConnection();
                channel = connection.CreateModel();

                channel.QueueDeclare(queue: "administrator_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                var consumer = new AsyncEventingBasicConsumer(channel);
                channel.BasicConsume(queue: "administrator_queue", autoAck: true, consumer: consumer);
                consumer.Received += async (eventSender, eventArgs) =>
                {
                    var message = Encoding.UTF8.GetString(eventArgs.Body.ToArray());
                    var currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    await Task.Run(() =>
                    {
                        richTextBox.Invoke((MethodInvoker)delegate
                        {
                            richTextBox.AppendText($"{currentDate}: {message}\n");
                        });
                    });

                    Console.WriteLine($"Received message: {currentDate}: {message}");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cleanup()
        {
            channel?.Close();
            channel?.Dispose();

            connection?.Close();
            connection?.Dispose();
        }
    }

}

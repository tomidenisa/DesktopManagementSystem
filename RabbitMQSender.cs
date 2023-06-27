using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RabbitMQ.Client.Events;

namespace CRUDOP2
{
    public class RabbitMQSender
    {
        private readonly ConnectionFactory _factory;
        private readonly string _exchange;
        private IConnection _connection;
        private IModel _channel;
        private BasicGetResult _receivedMessage;

        public RabbitMQSender(string hostName = "localhost", string user = "guest", string pass = "guest", string exchange = "amq.direct")
        {
            _factory = new ConnectionFactory() { HostName = hostName, UserName = user, Password = pass };
            _exchange = exchange;
        }
        private void Connect()
        {
            if (_connection == null)
            {
                _connection = _factory.CreateConnection();
                _channel = _connection.CreateModel();
            }
            else
            {
                if (!_connection.IsOpen)
                {
                    Disconnect();
                    Connect();
                }
            }
        }
        private void Disconnect()
        {
            _receivedMessage = null;

            if (_channel != null)
            {
                _channel.Close();
                _channel.Dispose();
                _channel = null;
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
           
        }
        public bool Write(string queueName, string message, string routingKey)
        {
            //if (string.IsNullOrEmpty(routingKey)) routingKey = "RK" + queueName;

            bool done = false, err = false;

            
            Connect();

            _channel.ConfirmSelect();

            //_channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, CreateQueueConnectArguments(queueName));
            var confirmSq = _channel.NextPublishSeqNo;

            var body = Encoding.UTF8.GetBytes(message);
            _channel.BasicReturn += (sender, ea) =>
            {
                if (ea.ReplyCode != 0)
                    

                err = true;
            };

            _channel.BasicAcks += (sender, ea) =>
            {
                if (confirmSq == ea.DeliveryTag)
                {
                    
                    done = true;
                }
            };
            _channel.BasicPublish(_exchange, routingKey, mandatory: true, basicProperties: null, body);
            while (!done)
                Thread.Sleep(1);
            //Disconnect();
            if (err) return false;
            return true;
        }
        public void Rollback()
        {
            if (_receivedMessage != null)
                _channel.BasicNack(_receivedMessage.DeliveryTag, multiple: false, true);
        }
        public string Read(string queueName, string routingKey)
        {
            
            Connect();

            _channel.ExchangeDeclare(_exchange, type: "direct", durable: true);
            _channel.QueueBind(queueName, _exchange, routingKey);

            _receivedMessage = _channel.BasicGet(queueName, autoAck: false);
            if (_receivedMessage?.Body != null)
            {
                var body = _receivedMessage.Body.ToArray();
                return Encoding.UTF8.GetString(body);
            };

            return null;
        }
        public List<string> ReadAll(string queueName, string routingKey)
        {
            Connect();

            _channel.ExchangeDeclare(_exchange, type: "direct", durable: true);
            _channel.QueueBind(queueName, _exchange, routingKey);

            var messages = new List<string>();
            bool continueReading = true;

            while (continueReading)
            {
                _receivedMessage = _channel.BasicGet(queueName, autoAck: false);

                if (_receivedMessage?.Body != null)
                {
                    var body = _receivedMessage.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    messages.Add(message);

                    // Acknowledge the message
                    _channel.BasicAck(deliveryTag: _receivedMessage.DeliveryTag, multiple: false);
                }
                else
                {
                    // No more messages to read
                    continueReading = false;
                }
            }

            return messages;
        }


        /* public void SendMessage(string queueName, string message)
         {
             try
             {
                 var factory = new ConnectionFactory()
                 {
                     HostName = _hostName,
                     UserName = _userName,
                     Password = _password
                 };

                 using (var connection = factory.CreateConnection())
                 using (var channel = connection.CreateModel())
                 {
                     channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                     byte[] body = Encoding.UTF8.GetBytes(message);

                     channel.BasicPublish(exchange: "", routingKey: "administrator",mandatory: true, basicProperties: null, body);
                 }
             } 
             catch (Exception ex)
             {
                 MessageBox.Show("RabbitMQ error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/
    }
}

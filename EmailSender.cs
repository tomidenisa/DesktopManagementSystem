using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOP2
{
    public class EmailSender
    {
        public static void SendEmailWithAttachment(string fromEmail, string toEmail, string subject, string body, string attachmentFilePath)
        {
           
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, "gmajvhmnijdtjlnf")
            };

            var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body
            };

            if (!string.IsNullOrEmpty(attachmentFilePath))
            {
                var attachment = new Attachment(attachmentFilePath);
                message.Attachments.Add(attachment);
            }

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Notificare trimisa cu succes!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trimitere esuata: " + ex.Message, "Email Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

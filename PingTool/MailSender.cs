using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PingTool
{
    class MailSender
    {
        public MailSender(AppSettings mailSettings, Letter _letter)
        {
            var fromMail = new MailAddress(mailSettings.MAIL_FROM, mailSettings.MAIL_SENDER_NAME);
            var toMail = new MailAddress(mailSettings.MAIL_TO, string.Empty);
            var smtp = new SmtpClient
            {
                Host = mailSettings.MAIL_SERVER_HOST,
                Port = mailSettings.MAIL_SERVER_PORT,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail.Address, mailSettings.MAIL_PASSWORD_FROM)
            };
            using (var message = new MailMessage(fromMail, toMail)
            {
                Subject = _letter.Subject,
                Body = _letter.Body
            })
            {
                try
                {
                    smtp.Send(message);
                    Logger.Log("Уведомление на почту отправлено.");
                }
                catch (Exception ex)
                {
                    Logger.Log($"Error: {ex.Message}");
                }
            }
        }

    }
}

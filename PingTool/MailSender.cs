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
        public MailSender(string _fromAddress, string _fromPassword, string _toAddress, Letter _letter)
        {
            var fromMail = new MailAddress(_fromAddress, "Zabbix");
            var toMail = new MailAddress(_toAddress, string.Empty);
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail.Address, _fromPassword)
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
                }
                catch (Exception ex)
                {
                    Logger.Log($"Error: {ex.Message}");
                }
            }
        }

    }
}

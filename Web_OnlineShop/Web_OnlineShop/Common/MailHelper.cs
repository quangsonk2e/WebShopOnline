using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;


namespace Web_OnlineShop.Common
{
    public class MailHelper
    {
        public void SendMail(string toEmailAddress, string subject, string content)
        {
            var fromEmailAddress = ConfigurationManager.AppSettings["FromEmailAdress"].ToString();
            var fromEmailDisplayAddress = ConfigurationManager.AppSettings["FromEmailDisplayName"].ToString();
            var fromEmailPassword = ConfigurationManager.AppSettings["FromEmailPassword"].ToString();
            var smtpHost = ConfigurationManager.AppSettings["SMTPHost"].ToString();
            var stmpPort = ConfigurationManager.AppSettings["SMTPPort"].ToString();
            var enableSsl = bool.Parse(ConfigurationManager.AppSettings["EnabledSSL"].ToString());

            string body = content;
            MailMessage message = new MailMessage(new MailAddress(fromEmailAddress, fromEmailPassword),new MailAddress(toEmailAddress));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = body;


            var client = new SmtpClient();
            client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            client.Host = smtpHost;
            client.Port = Convert.ToInt32(stmpPort);
            client.Send(message);

        }
    }
}
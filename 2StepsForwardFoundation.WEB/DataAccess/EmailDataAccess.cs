using _2StepsForwardFoundation.Models;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace _2StepsForwardFoundation.DataAccess
{
    public class EmailDataAccess
    {
        public EmailDataAccess() { }

        public void SendEmail(string from, string to, string subject, string body)
        {
            using (var dbContext = new Entities())
            {
                dbContext.usp_CreateEmail(from, to, subject, body);
            }
            try {
                using (var mail = new MailMessage(ConfigurationManager.AppSettings["NoReplyEmail"], to, subject, body))
                {
                    mail.To.Add(from);
                    mail.IsBodyHtml = true;
                    var client = new SmtpClient
                    {
                        Host = ConfigurationManager.AppSettings["Host"],
                        Port = 25,
                        Credentials = CredentialCache.DefaultNetworkCredentials,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = true,
                        EnableSsl = false
                    };
                    client.Send(mail);
                }
            }
            catch (SmtpException)
            {
                throw;
            }
        }

        public int AddToEmailingList(string email)
        {
            using (var dbContext = new Entities())
            {
                return dbContext.usp_EmailingListMaintenance(email, "A"); // A = Add
            }
        }

        public int RemoveFromEmailingList(string email)
        {
            using (var dbContext = new Entities())
            {
                return dbContext.usp_EmailingListMaintenance(email, "R"); // R = Remove
            }
        }
    }
}
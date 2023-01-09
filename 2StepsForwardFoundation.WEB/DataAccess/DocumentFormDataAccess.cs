using _2StepsForwardFoundation.Models;
using RazorEngine;
using RazorEngine.Templating;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace _2StepsForwardFoundation.DataAccess
{
    public class DocumentFormDataAccess
    {
        public DocumentFormDataAccess() { }

        public void CreateApplication(Application model)
        {
            using (var dbContext = new Entities())
            {
                dbContext.usp_ApplicationMaintenance(model.FirstName, model.MiddleName, model.LastName, model.Address, model.Address2, model.City, model.State, model.Zip,
                    model.Email, model.PhoneNumber, model.PlaceOfEmployment, model.TotalIncome, model.AmountNeeded, model.AppliedBefore, model.AssistanceProvided, model.BillRequestingPayment,
                    model.GovernmentAssistance, model.GovernmentAssistanceDetails, model.OtherAssistanceAppliedDetails,
                    model.HouseholdMemberNameAge1, model.HouseholdMemberNameAge2, model.HouseholdMemberNameAge3, model.HouseholdMemberNameAge4, model.HouseholdMemberNameAge5, model.HouseholdMemberNameAge6,
                    model.AssistanceNeedExplanation, model.OtherFactorsToReview, "A"); // A = Add
            }
            EmailCompletedApplication(model);
        }

        private void EmailCompletedApplication(Application model)
        {
            var templatePath = File.ReadAllText(HttpContext.Current.Server.MapPath("~/Views/EmailTemplates/ApplicationEmailTemplate.cshtml"));
            string body = Engine.Razor.RunCompile(templatePath, "ApplicationEmailTemplate", null, model);
            try {
                using (var mail = new MailMessage(ConfigurationManager.AppSettings["NoReplyEmail"], ConfigurationManager.AppSettings["ApplicationEmail"], string.Format("{0} {1}'s Application Form", model.FirstName, model.LastName), body))
                {
                    mail.To.Add(model.Email);
                    mail.Bcc.Add(ConfigurationManager.AppSettings["ApplicationEmail"]);
                    mail.IsBodyHtml = true;
                    var client = new SmtpClient
                    {
                        Host = ConfigurationManager.AppSettings["Host"],
                        Port = 25
                        //Credentials = CredentialCache.DefaultNetworkCredentials,
                        //DeliveryMethod = SmtpDeliveryMethod.Network,
                        //UseDefaultCredentials = true,
                        //EnableSsl = false
                    };
                    client.Send(mail);
                }
            }
            catch (SmtpException)
            {
                throw;
            }
        }

        public void CreateVolunteer(Volunteer model)
        {
            using (var dbContext = new Entities())
            {
                dbContext.usp_VolunteerMaintenance(model.FirstName, model.MiddleName, model.LastName, model.Address, model.Address2, model.City, model.State, model.Zip,
                    model.Email, model.PhoneNumber, model.Background, "A"); // A = Add
            }
            EmailCompletedVolunteer(model);
        }

        private void EmailCompletedVolunteer(Volunteer model)
        {
            var templatePath = File.ReadAllText(HttpContext.Current.Server.MapPath("~/Views/EmailTemplates/VolunteerEmailTemplate.cshtml"));
            string body = Engine.Razor.RunCompile(templatePath, "VolunteerEmailTemplate", null, model);
            try
            {
                using (var mail = new MailMessage(ConfigurationManager.AppSettings["NoReplyEmail"], ConfigurationManager.AppSettings["VolunteerEmail"], string.Format("{0} {1}'s Volunteer Form", model.FirstName, model.LastName), body))
                {
                    mail.To.Add(model.Email);
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
    }
}
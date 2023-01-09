using _2StepsForwardFoundation.DataAccess;
using _2StepsForwardFoundation.Models;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace _2StepsForwardFoundation.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(Email model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var eda = new EmailDataAccess();
                    eda.SendEmail(model.Sender, ConfigurationManager.AppSettings["ContactEmail"], model.Subject, model.Message);
                    TempData["EmailSuccess"] = "Email sent successfully.";
                    return Json(new { redirectTo = Url.Action("Contact", "Email") });
                }
                catch (Exception ex)
                {
                    TempData["EmailError"] = "There was an error sending email, please try again.";
                    return PartialView("_EmailForm", model);
                }
            }

            // If we got this far, something failed, redisplay form
            return PartialView("_EmailForm", model);
        }

        public ActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subscribe(EmailingList model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var eda = new EmailDataAccess();
                    eda.AddToEmailingList(model.Email);
                    TempData["Success"] = "Subscribed to emailing list successfully.";
                    return RedirectToAction("Subscribe", "Email");
                }
                catch (Exception ex)
                {
                    TempData["Error"] = "There was an error subscribing to emailing list, please try again.";
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        public ActionResult Unsubscribe(EmailingList model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var eda = new EmailDataAccess();
                    eda.RemoveFromEmailingList(model.Email);
                    TempData["Success"] = "Unsubscribed to emailing list successfully.";
                    return Json(new { url = Url.Action("Subscribe", "Email") });
                }
                catch (Exception ex)
                {
                    TempData["Error"] = "There was an error unsubscribing to emailing list, please try again.";
                    return Json(new { url = Url.Action("Subscribe", "Email") });
                }
            }

            // If we got this far, something failed, redisplay form
            TempData["Error"] = "There was an error unsubscribing to emailing list, please make sure email is valid and try again.";
            return Json(new { url = Url.Action("Subscribe", "Email") });
        }
    }
}
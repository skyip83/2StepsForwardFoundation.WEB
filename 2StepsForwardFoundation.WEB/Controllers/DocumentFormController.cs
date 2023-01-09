using _2StepsForwardFoundation.DataAccess;
using _2StepsForwardFoundation.Models;
using System;
using System.Web.Mvc;

namespace _2StepsForwardFoundation.Controllers
{
    public class DocumentFormController : Controller
    {
        public ActionResult Application()
        {
            return View();
        }

        public ActionResult SubmitApplication(Application model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dfda = new DocumentFormDataAccess();
                    dfda.CreateApplication(model);
                    TempData["ApplicationSuccess"] = "Thank you for your application. We will review your application as quickly as possible and will contact you if further information is needed, or if we would like to meet with you and proceed with the application review process. All assistance is paid directly to the business owed and you must be available to meet with our staff prior to approval.";
                    return Json(new { redirectTo = Url.Action("Application", "DocumentForm") });
                }
                catch (Exception ex)
                {
                    TempData["ApplicationError"] = "There was an error submitting the application, please try again.";
                    return PartialView("_ApplicationForm", model);
                }
            }

            // If we got this far, something failed, redisplay form
            return PartialView("_ApplicationForm", model);
        }

        public ActionResult Volunteer()
        {
            return View();
        }

        public ActionResult SubmitVolunteer(Volunteer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dfda = new DocumentFormDataAccess();
                    dfda.CreateVolunteer(model);
                    TempData["VolunteerSuccess"] = "Thank you for filling out our volunteer form. We will save your submission and contact future volunteers as needed.";
                    return Json(new { redirectTo = Url.Action("Volunteer", "DocumentForm") });
                }
                catch (Exception ex)
                {
                    TempData["VolunteerError"] = "There was an error submitting the volunteer form, please try again.";
                    return PartialView("_VolunteerForm", model);
                }
            }

            // If we got this far, something failed, redisplay form
            return PartialView("_VolunteerForm", model);
        }
    }
}
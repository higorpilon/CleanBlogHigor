using CleanBlogHigor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using System.Net.Mail;
using System.Web;
using CleanBlogHigor.Services;

namespace CleanBlogHigor.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ISmtpService _smtpService;

        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/Contact/ContactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            SmtpClient client = new SmtpClient();

            bool success = false;

            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");

            return PartialView("~/Views/Partials/Contact/ResultForm.cshtml", success ? successMessage : errorMessage);
        }
    }
}
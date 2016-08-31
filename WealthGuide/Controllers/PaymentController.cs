using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Payment.Models;

namespace WealthGuide.Controllers
{
    public class PaymentController : Controller
    {
        public const string CreditCardViewModelKey = "CreditCardViewModelKey";

        public CreditCardViewModel SessionCreditCardViewModel
        {
            get { return HttpContext.Session[CreditCardViewModelKey] as CreditCardViewModel; }
            set { HttpContext.Session[CreditCardViewModelKey] = value; }
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewData[CreditCardViewModelKey] = SessionCreditCardViewModel;
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost(CreditCardViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData[CreditCardViewModelKey] = SessionCreditCardViewModel;
                return View(viewModel);
            }
            SessionCreditCardViewModel = viewModel;
            return RedirectToAction("Index");
        }
    }
}
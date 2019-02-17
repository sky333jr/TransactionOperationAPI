using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransactionOpsAPI.Controllers
{
    public class AgreementController : Controller
    {
        // GET: Agreement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AgreementConsent(string btnSubmit)
        {
            if (btnSubmit.Trim().ToUpper() == "ACCEPT")
            {
                return View("Index");
            }
            else
            {
                string mMsg = "btnSubmit";
            }
            return View("Index");
        }
    }
}
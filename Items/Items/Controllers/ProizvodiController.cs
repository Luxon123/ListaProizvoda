using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Items.Controllers
{
    public class ProizvodiController : Controller
    {
        // GET: Proizvodi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("NewItemsForm");
        }

        public ActionResult Edit()
        {
            return View("EditItemForm");
        }
    }
}
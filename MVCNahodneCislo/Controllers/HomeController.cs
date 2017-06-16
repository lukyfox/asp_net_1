using MVCNahodneCislo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNahodneCislo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /NahodneCislo/
        public ActionResult Index()
        {
			Generator generator = new Generator();
			ViewBag.Cislo = generator.VratCislo();
			return View();
        }
    }
}
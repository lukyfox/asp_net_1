using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNahodneCislo.Models;

namespace MVCNahodneCislo.Controllers
{
    public class KalkulackaController : Controller
    {
        // GET: Kalkulacka
        public ActionResult Index()
        {
			Kalkulacka kalkulacka = new Kalkulacka();
			return View(kalkulacka); // binding - predavam primo hodnotu (instanci), nevyuzivam prenosovou tridu ViewBag nebo ViewData
        }

		[HttpGet]
		public ActionResult Index(string jmeno)
		{
			Kalkulacka kalkulacka = new Kalkulacka();
			ViewBag.Jmeno = jmeno; //predani hodnoty do View pres ViewBag zasobnik
			return View(kalkulacka); // binding - predavam primo hodnotu (instanci), nevyuzivam prenosovou tridu ViewBag nebo ViewData
		}

		[HttpPost]
		public ActionResult Index(Kalkulacka kalkulacka)
		{
			if(ModelState.IsValid)
			{
				kalkulacka.Vypocitej();
			}

			return View(kalkulacka);
		}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNahodneCislo.Models
{
	public class Kalkulacka
	{
		[Required(ErrorMessage = "Zadejte prosím číslo")]
		[Display(Name = "1. číslo")]	
		public int Cislo1 { get; set; }
		[Required(ErrorMessage = "Zadejte prosím číslo")]
		[Display(Name = "2. číslo")]
		public int Cislo2 { get; set; }
		public double Vysledek { get; set; }
		[Display(Name = "Operace")]
		public string Operace { get; set; }
		public List<SelectListItem> MozneOperace { get; set; }

		public Kalkulacka()
		{
			MozneOperace = new List<SelectListItem>();
			MozneOperace.Add(new SelectListItem { Text = "Secti", Value = "+", Selected = true });
			MozneOperace.Add(new SelectListItem { Text = "Odecti", Value = "-" });
			MozneOperace.Add(new SelectListItem { Text = "Vynasob", Value = "*" });
			MozneOperace.Add(new SelectListItem { Text = "Vydel", Value = "/" });
		}

		public void Vypocitej() 
		{
			switch(Operace)
			{
				case "+":
					Vysledek = Cislo1 + Cislo2;
					break;
				case "-":
					Vysledek = Cislo1 - Cislo2;
					break;
				case "*":
					Vysledek = Cislo1 * Cislo2;
					break;
				case "/":
					Vysledek = Cislo1 / Cislo2;
					break;
			}

		}

	}
}
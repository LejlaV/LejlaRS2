using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Mobile.Models
{
	public enum MenuItemTypeAdmin
	{
		Rezervacije,
		Pregledi,
		MedicinskiKartoni,
		Dijagnoze,
		Lijekovi,
		Usluge,
		Članci,
		Kategorije,
		//StomatološkaOrdinacija,
		//Gradovi,
		//Adrese,
		Odjava
	}
	public class HomeMenuItemAdmin
	{
		public MenuItemTypeAdmin Id { get; set; }
		public string Title { get; set; }
	}
}

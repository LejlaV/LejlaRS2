using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Mobile.Models
{
	public enum MenuItemType
	{
		KorisnickiProfil,
		MojMedicinskiKarton,
		MojeRezervacije,
		RezervisiTermin,
		Usluge,
		Članci,
		Preporuke,
		Odjava
	}
	public class HomeMenuItem
	{
		public MenuItemType Id { get; set; }

		public string Title { get; set; }
	}
}

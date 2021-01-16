using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class PacijentSearchRequest
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string KorisnickoIme { get; set; }
	}
}

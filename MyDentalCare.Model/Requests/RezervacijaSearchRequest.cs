using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class RezervacijaSearchRequest
	{
		public int? PacijentId { get; set; }
		public int? Mjesec { get; set; }
	}
}

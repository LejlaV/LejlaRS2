using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class UslugaUpsertRequest
	{
		public string Naziv { get; set; }
		public decimal? Cijena { get; set; }

	}
}

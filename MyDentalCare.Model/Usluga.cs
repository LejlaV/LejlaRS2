using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Usluga
	{
		public int UslugaId { get; set; }
		public string Naziv { get; set; }
		public decimal? Cijena { get; set; }
		public int zakazanoUsluga { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Lijek
	{
		public int LijekId { get; set; }
		public string Naziv { get; set; }
		public string Uputstvo { get; set; }
		public int propisanoLijekova { get; set; }
	}
}

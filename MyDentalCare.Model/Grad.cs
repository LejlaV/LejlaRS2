using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Grad
	{

		public int GradId { get; set; }
		public string Naziv { get; set; }
		public string PostanskiBroj { get; set; }
		public int DrzavaId { get; set; }
		public virtual Drzava Drzava { get; set; }
		public string DrzavaNaziv { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Adresa
	{
		public int AdresaId { get; set; }
		public string Naziv { get; set; }
		public int GradId { get; set; }
		public virtual Grad Grad { get; set; }
		public string GradNaziv { get; set; }

	}
}

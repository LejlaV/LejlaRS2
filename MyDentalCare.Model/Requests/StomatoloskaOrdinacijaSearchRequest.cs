using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class StomatoloskaOrdinacijaSearchRequest
	{
        public string Naziv { get; set; }
        public int AdresaId { get; set; }
    }
}

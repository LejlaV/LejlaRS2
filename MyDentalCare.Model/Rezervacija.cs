using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Rezervacija
	{
        public int RezervacijaId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Razlog { get; set; }
        public bool? Aktivna { get; set; }
        public int PacijentId { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public int UslugaId { get; set; }
        public virtual Usluga Usluga { get; set; }
        public string UslugaNaziv { get; set; }
    }
}

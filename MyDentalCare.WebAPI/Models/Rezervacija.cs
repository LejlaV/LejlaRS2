using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            Pregled = new HashSet<Pregled>();
        }

        public int RezervacijaId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Razlog { get; set; }
        public bool? Aktivna { get; set; }
        public int UslugaId { get; set; }
        public virtual Usluga Usluga { get; set; }
        public string UslugaNaziv { get; set; }
        public int PacijentId { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Usluga
    {
        public Usluga()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }

        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}

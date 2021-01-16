using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Adresa
    {
        public Adresa()
        {
            StomatoloskaOrdinacija = new HashSet<StomatoloskaOrdinacija>();
        }

        public int AdresaId { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<StomatoloskaOrdinacija> StomatoloskaOrdinacija { get; set; }
    }
}

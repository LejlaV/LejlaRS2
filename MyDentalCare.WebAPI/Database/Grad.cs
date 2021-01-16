using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Adresa = new HashSet<Adresa>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Adresa> Adresa { get; set; }
    }
}

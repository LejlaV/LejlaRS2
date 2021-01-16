using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Grad = new HashSet<Grad>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Grad> Grad { get; set; }
    }
}

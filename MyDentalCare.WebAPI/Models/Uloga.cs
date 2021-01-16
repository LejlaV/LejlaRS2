using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUloga { get; set; }
    }
}

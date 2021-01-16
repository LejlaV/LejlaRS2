using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class KorisnikUloga
    {
        public int KorisnikUlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}

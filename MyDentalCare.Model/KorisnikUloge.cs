using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class KorisnikUloge
	{
        public int KorisnikUlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}

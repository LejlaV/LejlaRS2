using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Clanak
    {
        public Clanak()
        {
            Ocjena = new HashSet<Ocjena>();
        }

        public int ClanakId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }
        public int KategorijaId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
    }
}

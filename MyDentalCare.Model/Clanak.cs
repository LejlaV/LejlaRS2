using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Clanak
	{
        public int ClanakId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }
        public int KategorijaId { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public string KategorijaNaziv { get; set; }
        public int KorisnikId { get; set; }
       // public virtual Korisnik Korisnik { get; set; }
        public string KorisnikIme { get; set; }
        public decimal? ProsjecnaOcjena { get; set; }

    }
}

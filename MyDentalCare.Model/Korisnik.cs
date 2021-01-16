using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Korisnik
	{
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string KorisnikPodaci { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public ICollection<KorisnikUloge> KorisnikUloge { get; set; }
    }
}

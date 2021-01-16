using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Clanak = new HashSet<Clanak>();
            KorisnikUloga = new HashSet<KorisnikUloga>();
            Pregled = new HashSet<Pregled>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<Clanak> Clanak { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUloga { get; set; }
        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

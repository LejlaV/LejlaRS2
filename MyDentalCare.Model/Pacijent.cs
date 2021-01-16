using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Pacijent
	{
        public int PacijentId { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string PacijentPodaci { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}

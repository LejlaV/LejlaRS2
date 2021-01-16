using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Pacijent
    {
        public Pacijent()
        {
            MedicinskiKarton = new HashSet<MedicinskiKarton>();
            Ocjena = new HashSet<Ocjena>();
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int PacijentId { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<MedicinskiKarton> MedicinskiKarton { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}

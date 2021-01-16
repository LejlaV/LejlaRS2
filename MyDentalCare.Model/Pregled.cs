using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Pregled
	{
        public int PregledId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public virtual Dijagnoza Dijagnoza { get; set; }
        public int DijagnozaId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public virtual Lijek Lijek { get; set; }
        public int LijekId { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
        public int RezervacijaId { get; set; }
        public virtual MedicinskiKarton MedicinskiKarton { get; set; }
        public int MedicinskiKartonId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class StomatoloskaOrdinacija
    {
        public int StomatoloskaOrdinacijaId { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime? RadnoVrijemeOd { get; set; }
        public DateTime? RadnoVrijemeDo { get; set; }
        public int AdresaId { get; set; }

        public virtual Adresa Adresa { get; set; }
    }
}

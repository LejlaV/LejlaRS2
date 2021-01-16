using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class StomatoloskaOrdinacijaUpsertRequest
	{
        [Required]
        public int AdresaId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Naziv { get; set; }

        [EmailAddress(ErrorMessage = "Niste unijeli ispravnu e-mail adresu!")]
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime? RadnoVrijemeOd { get; set; }
        public DateTime? RadnoVrijemeDo { get; set; }
    }
}

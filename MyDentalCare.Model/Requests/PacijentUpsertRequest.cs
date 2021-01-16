using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class PacijentUpsertRequest
	{
        public DateTime? DatumRegistracije { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Prezime { get; set; }

        [EmailAddress(ErrorMessage = "Niste unijeli ispravnu e-mail adresu!")]
        public string Email { get; set; }
        public string BrojTelefona { get; set; }

        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}

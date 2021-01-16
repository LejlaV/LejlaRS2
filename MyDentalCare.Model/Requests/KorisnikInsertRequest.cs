using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class KorisnikInsertRequest
	{
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        
        [EmailAddress(ErrorMessage = "Niste unijeli ispravnu e-mail adresu!")]
        public string Email { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
    }
}

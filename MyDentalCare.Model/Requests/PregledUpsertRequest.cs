using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class PregledUpsertRequest
	{
        [Required]
        public DateTime DatumVrijeme { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Naziv { get; set; }
        public string Opis { get; set; }

        [Required]
        public int DijagnozaId { get; set; }
        
        [Required]
        public int KorisnikId { get; set; }
        
        [Required]
        public int LijekId { get; set; }

        [Required]
        public int RezervacijaId { get; set; }

        [Required]
        public int MedicinskiKartonId { get; set; }
    }
}

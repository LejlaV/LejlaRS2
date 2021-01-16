using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class MedicinskiKartonUpsertRequest
	{
        [Required]
        [MinLength(4)]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        
        [Required]
        public DateTime DatumVrijeme { get; set; }

        [Required]
        public int PacijentId { get; set; }
    }
}

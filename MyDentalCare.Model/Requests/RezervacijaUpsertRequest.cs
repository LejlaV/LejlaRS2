using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class RezervacijaUpsertRequest
	{
		[Required]
		public DateTime DatumVrijeme { get; set; }

		[Required(AllowEmptyStrings = false)]
		[MinLength(4)]
		public string Razlog { get; set; }
		public bool? Aktivna { get; set; }

		[Required]
		public int PacijentId { get; set; }

		[Required]
		public int UslugaId { get; set; }
	}
}

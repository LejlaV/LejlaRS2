using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class LijekUpsertRequest
	{
		[Required(AllowEmptyStrings = false)]
		[MinLength(4)]
		public string Naziv { get; set; }
		public string Uputstvo { get; set; }
	}
}

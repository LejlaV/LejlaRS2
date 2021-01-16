using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class OcjenaUpsertRequest
	{
		public decimal Ocjena1 { get; set; }
		public int ClanakId { get; set; }
		public int PacijentId { get; set; }
	}
}

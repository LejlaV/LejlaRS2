using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class Ocjena
	{
        public int OcjenaId { get; set; }
        public decimal Ocjena1 { get; set; }
        public int ClanakId { get; set; }
        public string Clanak { get; set; }
        public int PacijentId { get; set; }
        public string Pacijent { get; set; }
    }
}

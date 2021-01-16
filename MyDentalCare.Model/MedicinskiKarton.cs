using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Model
{
	public class MedicinskiKarton
	{
        public int MedicinskiKartonId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public int PacijentId { get; set; }

    }
}

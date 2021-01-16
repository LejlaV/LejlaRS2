using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class MedicinskiKarton
    {
        public MedicinskiKarton()
        {
            Pregled = new HashSet<Pregled>();
        }

        public int MedicinskiKartonId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public int PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

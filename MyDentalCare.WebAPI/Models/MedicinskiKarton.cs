using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
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
        public string PacijentIme { get; set; }
        public string PacijentPrezime { get; set; }
        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

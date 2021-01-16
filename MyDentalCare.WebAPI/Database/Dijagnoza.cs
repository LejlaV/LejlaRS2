using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Dijagnoza
    {
        public Dijagnoza()
        {
            Pregled = new HashSet<Pregled>();
        }

        public int DijagnozaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

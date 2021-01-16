using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Lijek
    {
        public Lijek()
        {
            Pregled = new HashSet<Pregled>();
        }

        public int LijekId { get; set; }
        public string Naziv { get; set; }
        public string Uputstvo { get; set; }

        public virtual ICollection<Pregled> Pregled { get; set; }
    }
}

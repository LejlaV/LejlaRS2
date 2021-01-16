using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Models
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Clanak = new HashSet<Clanak>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Clanak> Clanak { get; set; }
    }
}

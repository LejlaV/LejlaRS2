using System;
using System.Collections.Generic;

namespace MyDentalCare.WebAPI.Database
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public decimal? Ocjena1 { get; set; }
        public int PacijentId { get; set; }
        public int ClanakId { get; set; }

        public virtual Clanak Clanak { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}

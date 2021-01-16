using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
	public class ClanakUpsertRequest
	{
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Naslov { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }

        [Required]
        public int KategorijaId { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}

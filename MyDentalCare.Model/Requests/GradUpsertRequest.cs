using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDentalCare.Model.Requests
{
    public class GradUpsertRequest
    {
        [Required]
        public int DrzavaId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        [MinLength(4)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        [MinLength(4)]
        public string PostanskiBroj { get; set; }
    }
}

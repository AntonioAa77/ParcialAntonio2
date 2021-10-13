using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialAntonio2.Models
{
    public class Carta
    {
        [Key]
        public string NaipeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Color { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }




    }
}

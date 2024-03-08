using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Servizio
    {
        [Key]
        public int Servizio_ID { get; set; }

        // Tipo
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Tipo Camera")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "il tipo deve contenere meno di 50 caratteri, almeno 2")]
        public string Tipo { get; set; }


    }
}
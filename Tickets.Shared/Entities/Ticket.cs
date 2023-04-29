﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Tickets.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime Date { get; set; }

        [Display(Name = "Usada")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool Used { get; set; }

        [Display(Name = "Porteria")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Entrance { get; set; } = null!;


    }
}
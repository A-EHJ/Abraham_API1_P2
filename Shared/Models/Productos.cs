﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abraham_API1_P2.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el nombre del producto.")]
        public string? Descripción { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el tipo del producto.")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Existensia del producto.")]
        [Range(1, long.MaxValue, ErrorMessage = "La Existensia debe ser mayor que 0.")]
        public long Existensia { get; set; }

        [ForeignKey("ProductoId")]
        public ICollection<Entradas> Entradas { get; set; } = new List<Entradas>();

        [ForeignKey("ProductoId")]
        public ICollection<EntradasDetalle> EntradasDetalle { get; set; } = new List<EntradasDetalle>();
    }
}

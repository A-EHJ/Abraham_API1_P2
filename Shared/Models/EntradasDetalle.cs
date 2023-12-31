﻿using System.ComponentModel.DataAnnotations;

namespace Abraham_API1_P2.Shared.Models
{
    public class EntradasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int EntradaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el producto que desea.")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la cantidad que desea.")]
        [Range(1, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0.")]
        public double CantidadUtilizada { get; set; }
    }
}

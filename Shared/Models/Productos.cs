using System;
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
        [Range(0, 1, ErrorMessage = "El tipo debe ser Fruto seco(0) o Mixto(1).")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Existensia del producto.")]
        [Range(1, double.MaxValue, ErrorMessage = "La Existensia debe ser mayor que 0.")]
        public double Existencia { get; set; }
    }
}

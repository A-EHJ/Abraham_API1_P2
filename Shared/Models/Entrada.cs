using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abraham_API1_P2.Shared.Models
{
    internal class Entrada
    {
        [Key]
        public int EntradaId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es obligatorio introducir el concepto de la entrada.")]
        public string? Concepto { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el proveedor de la entrada.")]
        public double PesoTotal { get; set; }

        [ForeignKey("ProductoId")]
        [Required(ErrorMessage = "Es obligatorio introducir el producto.")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la cantidad que se produjo.")]
        public int CantidadProducida { get; set; }


    }
}

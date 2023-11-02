using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abraham_API1_P2.Shared.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es obligatorio introducir el concepto de la entrada.")]
        public string? Concepto { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el proveedor de la entrada.")]
        public double PesoTotal { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el producto.")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la cantidad que se produjo.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0.")]
        public int CantidadProducida { get; set; }

        [ForeignKey("EntradaId")]
        public ICollection<EntradasDetalle> EntradasDetalle { get; set; } = new List<EntradasDetalle>();
    }
}

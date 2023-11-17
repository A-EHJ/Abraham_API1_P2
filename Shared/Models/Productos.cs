using System.ComponentModel.DataAnnotations;

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
        public double Existencia { get; set; }
    }
}

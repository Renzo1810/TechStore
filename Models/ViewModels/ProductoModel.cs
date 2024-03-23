using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Models.ViewModels
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public required string NombreProducto { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public required string Descripción { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Precio { get; set; }

        public decimal Igv => Precio * 0.18M; // Calcula el IGV (Impuesto General a las Ventas)
    }
}
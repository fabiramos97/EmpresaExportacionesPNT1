using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EmpresaExportaciones.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "NOMBRE")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [StringLength(20)]
        public string nombre { get; set; }

        [Display(Name = "DESCRIPCION")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [StringLength(50)]
        public string descripcion { get; set; }

        [Display(Name = "PRECIO")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio no puede ser negativo.")]
        public double precio { get; set; }

        [Display(Name = "STOCK")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(0, double.MaxValue, ErrorMessage = "El stock no puede ser negativo.")]
        public double stock { get; set; }

        [Display(Name = "TIPO")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [EnumDataType(typeof(TipoDeProducto))]
        public TipoDeProducto tipoDeProducto { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace EmpresaExportaciones.Models
{
    public class Pedido
    {
        [Key]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "PEDIDO")]
        public int id { get; set; }

        [Display(Name = "CLIENTE")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(1, double.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a 0.")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Display(Name = "PRODUCTO")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(1, double.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a 0.")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Display(Name = "CANTIDAD")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(1, double.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a 0.")]
        public int cantProducto { get; set; }


        [Display(Name = "PRECIO")]
        [Range(1, double.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a 0.")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        public int precio { get; set; }


        [Display(Name = "FECHA")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        public DateTime fecha { get; set; }

        [Display(Name = "ESTADO")]
        [EnumDataType(typeof(Estado))]
        public Estado estado { get; set; }
    }
}

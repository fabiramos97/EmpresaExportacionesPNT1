using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaExportaciones.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "DNI")]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo {0} debe ser un número positivo.")]
        public int dniCliente { get; set; }

        [Display(Name = "NOMBRE")]
        [StringLength(20)]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        public string nombreCliente { get; set; }

        [Display(Name = "APELLIDO")]
        [StringLength(20)]
        [Required(ErrorMessage = "Debe especificar un valor para {0}.")]
        public string apellidoCliente { get; set; }
    }
}

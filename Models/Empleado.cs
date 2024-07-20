using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TerminalV1.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El cargo es obligatorio")]
        public int CargoId { get; set; }
        [ForeignKey("CargoId")]
        public Cargo Cargo { get; set; }
    }
}

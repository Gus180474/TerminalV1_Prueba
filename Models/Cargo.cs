using System.ComponentModel.DataAnnotations;

namespace TerminalV1.Models
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }
        [MaxLength(50)]
        public string Descripcion { get; set; }
    }
}

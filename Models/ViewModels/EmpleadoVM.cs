using Microsoft.AspNetCore.Mvc.Rendering;

namespace TerminalV1.Models.ViewModels
{
    public class EmpleadoVM
    {
        public Empleado Empleado { get; set; }

        public List<SelectListItem> ListaCargo { get; set; }
    }
}

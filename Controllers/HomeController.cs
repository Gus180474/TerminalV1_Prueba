using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TerminalV1.Data;
using TerminalV1.Models;
using TerminalV1.Models.ViewModels;

namespace TerminalV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbTerminalContext _DBContext;

        public HomeController(DbTerminalContext context)
        {
            _DBContext = context;
        }

        public IActionResult Index()
        {
            //List<Empleado> lista = _DBContext.Empleado.Include(c=>c.Cargo).ToList();
            return View();
        }

        //prueba
        public IActionResult Usuarios()
        {
            List<Empleado> lista = _DBContext.Empleado.Include(c => c.Cargo).ToList();
            return View(lista);
        }


        [HttpGet]
        public IActionResult Empleado_Detalle(int idEmpleado)
        {
            EmpleadoVM EmpleadoVM = new EmpleadoVM()
            {
                Empleado = new Empleado(),
                ListaCargo = _DBContext.Cargo.Select(cargo => new SelectListItem()
                {
                    Text = cargo.Descripcion,
                    Value = cargo.IdCargo.ToString()
                }).ToList()
            };

            if (idEmpleado != 0)
            {
                EmpleadoVM.Empleado = _DBContext.Empleado.Find(idEmpleado);   
            }
            return View(EmpleadoVM);
        }

        [HttpPost]
        public IActionResult Empleado_Detalle(EmpleadoVM EmpleadoVM)
        {
            if (EmpleadoVM.Empleado.IdEmpleado == 0)
            {
                _DBContext.Empleado.Add(EmpleadoVM.Empleado);
            }
            else
            {
                _DBContext.Empleado.Update(EmpleadoVM.Empleado);
            }
            _DBContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Eliminar(int idEmpleado)
        {
            Empleado Empleado = _DBContext.Empleado.Include(c=>c.Cargo).Where(e=>e.IdEmpleado== idEmpleado).FirstOrDefault();
            return View(Empleado);
        }

        [HttpPost]
        public IActionResult Eliminar(Empleado Empleado)
        {
            _DBContext.Empleado.Remove(Empleado);
            _DBContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}

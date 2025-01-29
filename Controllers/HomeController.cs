using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TiendaProyecto.Data;
using TiendaProyecto.Models;

namespace TiendaProyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {


            var enrollment = new User();

            // Pasar el modelo vacío a la vista
            return View(enrollment);
        }


        // EndPoint para enrollments 

        [HttpPost]
        public IActionResult EnrollStudent(User enrollment)
        {
            if (ModelState.IsValid)
            {
              
                return RedirectToAction("Index"); 
            }

            // Si hay errores de validación, regresar al formulario
            return View(enrollment);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

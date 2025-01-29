using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace TiendaProyecto.Controllers
{
    public class Accounts : Controller
    {


        public IActionResult Login()
        {
          
            return View();
        }



    }
}

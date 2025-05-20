using Microsoft.AspNetCore.Mvc;
using PracticaSemana1.Models;
using PracticaSemana1.Data;
using System.Linq;

namespace PracticaSemana1.Controllers
{
    public class AccountController : Controller
    {
        private readonly LoginDbContext _context;

        public AccountController(LoginDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

                if (user != null)
                {
                    TempData["Success"] = "Inicio de sesión exitoso.";
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Usuario o contraseña incorrectos.");
            }

            return View(model);
        }
    }
}

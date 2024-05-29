using gas_station;
using Microsoft.AspNetCore.Mvc;
using YourProjectNamespace.Models;

namespace YourProjectNamespace.Controllers
{
    public class AccountController : Controller
    {
        private readonly WebsiteContext _context;

        public AccountController(WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Створення нового користувача з Email та PasswordHash
                var user = new Login { Email = model.Email, PasswordHash = model.PasswordHash };

                // Додавання користувача до контексту
                _context.Login.Add(user);

                // Збереження змін у базі даних
                _context.SaveChanges();

                // Перенаправлення на сторінку після успішної реєстрації
                return RedirectToAction("RegComp");
            }
            // Якщо модель не є дійсною, поверніть форму з помилками
            return View("FailReg", model);
        }

        public IActionResult RegComp()
        {
            return View();
        }
    }
}

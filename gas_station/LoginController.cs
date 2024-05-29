using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace gas_station
{
    public class LoginController : Controller
    {
        private readonly WebsiteContext _context;

        public LoginController(WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Login.FirstOrDefault(u => u.Email == model.Email);
                if (user != null)
                {
                    if (user.PasswordHash == model.PasswordHash)
                    {
                        return RedirectToAction("Success");
                    }
                }
            }
            return RedirectToAction("Fail");
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Fail()
        {
            return View();
        }
    }
}

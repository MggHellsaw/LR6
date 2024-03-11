using LR6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LR6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user.DateOfBirth.AddYears(16) > DateTime.Now)
            {
                return RedirectToAction("OrderProducts", "Product", new { quantity = 1 }); // redirect to order page with quantity 1
            }
            else
            {
                return RedirectToAction("Register"); // redirect back to registration page if age requirement is not met
            }
        }
    }
}

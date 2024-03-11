using Microsoft.AspNetCore.Mvc;
using System;

namespace LR6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Order(int quantity)
        {
            if (quantity <= 0)
            {
                ModelState.AddModelError("quantity", "Кількість товару повинна бути більше нуля.");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("OrderConfirmation");
            }
            else
            {
                return View();
            }
        }

        public IActionResult OrderConfirmation()
        {
            return View();
        }
    }
}

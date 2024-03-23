using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;
using TechStore.Models.ViewModels;

namespace TechStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}
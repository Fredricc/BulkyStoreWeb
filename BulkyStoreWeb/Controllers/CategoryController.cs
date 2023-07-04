using Microsoft.AspNetCore.Mvc;

namespace BulkyStoreWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

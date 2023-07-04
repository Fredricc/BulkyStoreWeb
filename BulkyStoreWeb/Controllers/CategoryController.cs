using BulkyStoreWeb.Data;
using BulkyStoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyStoreWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            this._db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}

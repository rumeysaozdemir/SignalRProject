using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace FiorelloBackendWidthDB.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebAppAdminGastos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

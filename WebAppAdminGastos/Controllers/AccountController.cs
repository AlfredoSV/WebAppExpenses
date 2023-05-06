using Microsoft.AspNetCore.Mvc;

namespace WebAppAdminGastos.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

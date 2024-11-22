using Microsoft.AspNetCore.Mvc;
using WebApplication3.DataAccess;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
    }
}

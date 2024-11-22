using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.DataAccess;
using WebApplication3.Models;
using WebApplication3.ViewModel.Sliders;

namespace WebApplication3.Controllers
{
    public class HomeController(UniquoDbContext _sql) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var datas = await _sql.Sliders
                 .Where(x => !x.IsDeleted)
                 .Select(x => new SliderItemVM
                 {
                     ImageUrl = x.ImageUrl,
                     Link = x.Link,
                     Title = x.Title,
                     Subitle = x.Subitle
                 }).ToListAsync();
            return View(datas);
        }
        //<a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>

        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using WebApplication3.DataAccess;
using WebApplication3.ViewModel.Sliders;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(UniquoDbContext _sql, IWebHostEnvironment _eny) : Controller
    {
        public async Task<IActionResult> Index()
        {

            return View(await _sql.Sliders.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateVM slider)
        {
            if (!slider.File.ContentType.StartsWith("image"))
            {
                ModelState.AddModelError("File", "File type must be image");
                return View();
            }//sekil max nece mb kb yaddas tutumu ola bile
            if (slider.File.Length > 2 * 1024 * 1024) { return View(); }

            if (!ModelState.IsValid) return View();

            //random file adi verir 12 simvollu
            string newFileName = Path.GetRandomFileName() + Path.GetExtension(slider.File.FileName);//sekil.jpg

            using (Stream strem = System.IO.File.Create(Path.Combine(_eny.WebRootPath, "imgs", "sliderImg", newFileName)))
            {
                await slider.File.CopyToAsync(strem);
            }
            Slider slider1 = new Slider
            {
                ImageUrl = newFileName,
                Link = slider.Link,
                Subitle = slider.Subitle,
                Title = slider.Title,
            };
            await _sql.Sliders.AddAsync(slider1);
            await _sql.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

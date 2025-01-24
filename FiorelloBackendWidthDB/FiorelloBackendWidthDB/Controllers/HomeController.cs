using FiorelloBackendWidthDB.Data;
using FiorelloBackendWidthDB.Models;
using FiorelloBackendWidthDB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloBackendWidthDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            IEnumerable<Blog> blogs=await _context.Blogs.Take(3).ToListAsync();
            IEnumerable<Slider> sliders=await _context.Sliders.ToListAsync();
            SliderInfo sliderInfos=await _context.SlidersInfos.FirstOrDefaultAsync();
            IEnumerable<Expert> experts=await _context.Experts.ToListAsync();
            IEnumerable<Testimonial> testimonials = await _context.Testimonials.ToListAsync(); 
            IEnumerable<Instagram> instagrams=await _context.Instagrams.ToListAsync();
            About abouts = await _context.Abouts.FirstOrDefaultAsync();
            HomeVM model = new()
            {
                Abouts=abouts,
                Instagrams=instagrams,
                Testimonials=testimonials,
                Experts = experts,
                Sliders = sliders,
                SliderInfos = sliderInfos,
                Blogs = blogs
            };
            return View(model);
        }
    }
}

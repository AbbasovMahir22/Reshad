using FiorelloBackendWidthDB.Models;
using FiorelloBackendWidthDB.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FiorelloBackendWidthDB.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }   
        public DbSet<About> Abouts { get; set; }
    }
}

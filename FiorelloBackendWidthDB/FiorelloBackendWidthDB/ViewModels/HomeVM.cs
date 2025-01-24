using FiorelloBackendWidthDB.Models;

namespace FiorelloBackendWidthDB.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfos{ get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
        public About Abouts { get; set; }
    }
}

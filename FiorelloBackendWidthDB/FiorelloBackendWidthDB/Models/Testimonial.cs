using System.Reflection.Metadata.Ecma335;

namespace FiorelloBackendWidthDB.Models
{
    public class Testimonial:BaseEntity
    {
        public string Img { get; set; }
        public string About { get; set; }
        public string Name { get; set; }
        public string Duty { get; set; }
    }
}

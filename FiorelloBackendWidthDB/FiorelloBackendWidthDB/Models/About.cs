using System.Reflection.Metadata.Ecma335;

namespace FiorelloBackendWidthDB.Models
{
    public class About:BaseEntity
    {
        public string Video { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hand { get; set; }
        public string Unique { get; set; }
        public string Best { get; set; }


    }
}

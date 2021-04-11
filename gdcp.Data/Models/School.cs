using System.ComponentModel.DataAnnotations;

namespace gdcp.Data.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string SpeedConnectivity { get; set; }
        public string TypeConnectivity { get; set; }
        public User User { get; set; }
       
    }
}

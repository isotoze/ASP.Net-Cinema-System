using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCinemaApplication.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string bbfcRating { get; set; }
        public string description { get; set; }
        public DateTime releaseDate { get; set; }
        public string genre { get; set; }
        public string imageName { get; set; }
    }
}

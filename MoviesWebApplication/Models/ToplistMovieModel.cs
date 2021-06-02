using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Models
{
    public class ToplistMovieModel
    {
        public bool IsSelected { get; set; }
        public string ToplistName { get; set; }
        public int ToplistId { get; set; }
        public int MovieId { get; set; }
    }
}

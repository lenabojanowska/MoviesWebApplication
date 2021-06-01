using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    public class ToplistMoviesDBO
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ToplistId { get; set; }
    }
}

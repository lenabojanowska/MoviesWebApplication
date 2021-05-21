using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    [Keyless]
    public class RatingDBO
    {
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public MovieDBO Movie { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
    }
}

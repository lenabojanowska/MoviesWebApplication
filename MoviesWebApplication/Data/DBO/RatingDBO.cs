using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    public class RatingDBO
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public MovieDBO Movie { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
    }
}

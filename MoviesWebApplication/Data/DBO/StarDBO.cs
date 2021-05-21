using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    [Keyless]
    public class StarDBO
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public PersonDBO Person { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public MovieDBO Movie { get; set; }
    }
}

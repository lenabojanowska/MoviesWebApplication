using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    public class ToplistDBO
    {
        public int Id { get; set; }

        public UserDBO User { get; set; }

        public ICollection<MovieDBO> Movies { get; set; }

        public bool IsPublic { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    public class ToplistDBO
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        //movieIDs
        public ICollection<MovieDBO> Movies { get; set; }
        [Display(Name = "Public")]
        public bool IsPublic { get; set; }
    }
}

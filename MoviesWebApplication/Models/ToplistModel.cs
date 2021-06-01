using MoviesWebApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Models
{
    public class ToplistModel
    {
        public ToplistModel()
        {
            this.Movies = new List<MovieDBO>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        [Display(Name = "Public")]
        public bool IsPublic { get; set; }

        public ICollection<MovieDBO> Movies { get; set; }
    }
}

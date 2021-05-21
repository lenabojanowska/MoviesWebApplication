using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Models
{
    public class MoviesModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }
        public enum ECategory { Action = 0, Adventure = 1, Horror = 2, Drama = 3, Romance = 4, Comedy = 5 }
    }
}

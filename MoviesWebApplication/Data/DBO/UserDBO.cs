using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data.DBO
{
    public class UserDBO
    {
        [Key]
        public string Email { get; set; }
    }
}

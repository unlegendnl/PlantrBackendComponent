using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userMicroservice.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

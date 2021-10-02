using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using userMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace userMicroservice.Data
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options) : base(options)
        {
        }

        public DbSet<userModel> User { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using authService.Context;
using authService.Models;

namespace authService.Context
{
    public static class Seed
    {
        public static void SeedDb(this UserContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                dbContext.Users.Add(new User
                {
                    UserName = "miguel",
                    Password = "jemoeder"
                    //uid auto generated
                });
                dbContext.Users.Add(new User
                {
                    UserName = "johnny",
                    Password = "jemoeder"
                });
                dbContext.Users.Add(new User
                {
                    UserName = "hans",
                    Password = "jemoeder"
                });

                dbContext.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using userMicroservice.Models;

namespace userMicroservice.Data
{
    public class DbInitializer
    {
        public static void Initialize(userContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{userId = 1, Email = "miguelr@hotmail.com", Password = "jemoeder1", userName = "Miguel"},
                new User{userId = 2, Email = "miguelsoto@hotmail.com", Password = "jemoeder2", userName = "Soto"},
                new User{userId = 3, Email = "miguelsotoconuecar@hotmail.com", Password = "jemoeder3", userName = "Miguel"}
            };

            foreach (User s in users)
            {
                context.Users.Add(s);
            }

            context.SaveChanges();
        }
    }
}

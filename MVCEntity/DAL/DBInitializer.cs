using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCEntity.Models;

namespace MVCEntity.DAL
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
            new User{Name="Carson"},
            new User{Name="Meredith"},
            new User{Name="Arturo"},
            new User{Name="Gytis"},
            new User{Name="Yan"},
            new User{Name="Peggy"},
            new User{Name="Laura"},
            new User{Name="Nino"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order{DateCreated = DateTime.Parse("2018-09-01"), UserID = 1},
            new Order{DateCreated = DateTime.Parse("2018-09-02"), UserID = 1},
            new Order{DateCreated = DateTime.Parse("2018-09-03"), UserID = 1},
            new Order{DateCreated = DateTime.Parse("2018-09-08"), UserID = 2},
            new Order{DateCreated = DateTime.Parse("2018-09-07"), UserID = 2},
            new Order{DateCreated = DateTime.Parse("2018-09-05"), UserID = 3},
            new Order{DateCreated = DateTime.Parse("2018-09-06"), UserID = 3,}
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
           
        }
    }
}
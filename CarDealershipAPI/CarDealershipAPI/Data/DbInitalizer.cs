using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI.Data
{
    public static class DbInitalizer
    {
        public static void Initialize(CarDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any())
            {
                return;
            }

            context.Cars.Add(new Data.Models.Car
            {
                Make = "Chevrolet",
                Model = "Malibu",
                Year = 2009,
                Color = "Blue"
            });
            context.Cars.Add(new Data.Models.Car
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 1969,
                Color = "Red"
            });
            context.Cars.Add(new Data.Models.Car
            {
                Make = "Dodge",
                Model = "Neon",
                Year = 1997,
                Color = "Red"
            });
            context.Cars.Add(new Data.Models.Car
            {
                Make = "Nissan",
                Model = "Maxima",
                Year = 1995,
                Color = "Black"
            });
            context.Cars.Add(new Data.Models.Car
            {
                Make = "Jeep",
                Model = "Grand Cherokee",
                Year = 2021,
                Color = "White"
            });

            context.SaveChanges();
        }
    }
}

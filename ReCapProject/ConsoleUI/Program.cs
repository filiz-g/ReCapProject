using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

           
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            carManager.Add(new Car { Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 500, ModelYear = 2019, Description = "Peugeot" });

        }
    }
}

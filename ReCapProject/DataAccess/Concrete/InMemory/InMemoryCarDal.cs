using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
      

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 749, ModelYear = 2018, Description = "Mercedes" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 499, ModelYear = 2018, Description = "Audi A3" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 349, ModelYear = 2019, Description = "Nissan Juke" },
                new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 480, ModelYear = 2015, Description = "BMW 2018" }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            var result = _cars.Any(c => c.Description == "Fiat");
            Console.WriteLine(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllBy(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = carToUpdate.Description;
        }

    

    }
}

       
    

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Araba Eklendi.");
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba Eklenemedi. Araba ismi minimum 2 karakter olmalı ve günlük fiyatı ise 0'dan büyük olmalıdır.");
            }
        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColorId(int id)
        {

            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}

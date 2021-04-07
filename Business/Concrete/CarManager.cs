using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _car;

        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _car.Add(car);
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır" +
                                 "Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
            
        }

        public void Delete(Car car)
        {
            _car.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _car.GetByAll();
        }

        public void Update(Car car)
        {
            _car.Update(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _car.GetCarDetails();
        }
    }
}

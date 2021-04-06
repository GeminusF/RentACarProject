using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Car> GetAll()
        {
            return _car.GetByAll();
        }
    }
}

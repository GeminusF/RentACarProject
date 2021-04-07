using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {
                    Id =1 ,
                    BrandId = 1,
                    ColorId = 4,
                    ModelYear = "2003",
                    DailyPrice = 23,
                    Description = "Aile masini"
                },
                new Car {
                    Id =2,
                    BrandId = 5,
                    ColorId = 4,
                    ModelYear = "2021",
                    DailyPrice = 200,
                    Description = "Super Sport"
                },
                new Car {
                    Id =3 ,
                    BrandId = 3,
                    ColorId = 12,
                    ModelYear = "2018",
                    DailyPrice = 100,
                    Description = "Elektrikli masin"
                }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(_cars => car.Id == carToDelete.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetByAll()
        {
            return _cars;
        }

        public List<Car> GetByAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(_cars => car.Id == carToUpdate.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

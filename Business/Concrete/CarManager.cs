using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _car.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }

            return new ErrorResult(Messages.InvalidCarAdded);
        }

        public IResult Delete(Car car)
        {
            _car.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new SuccessDataResult<List<Car>>(_car.GetByAll(), Messages.CarListed);
            //}
            return new SuccessDataResult<List<Car>>(_car.GetByAll(), Messages.CarListed);
        }

        public IResult Update(Car car)
        {
            _car.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_car.GetCarDetails());
        }

        public IDataResult<Car> GetByBrandId(int id)
        {
           return new SuccessDataResult<Car>(_car.GetCarsByBrandId(c => c.Id == id), Messages.CarListedByBrandId);
        }

        public IDataResult<Car> GetByColorId(int id)
        {
            return new SuccessDataResult<Car>(_car.GetCarsByColorId(c => c.Id == id),Messages.CarListedByColorId);
        }
    }
}

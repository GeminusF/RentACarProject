using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
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

        [SecuredOperation("product.add ,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        //[PerformanceAspect(5)]
        public IResult Add(Car car)
        {
            _car.Add(car);
            return new SuccessResult(Messages.CarAdded);
            //if (car.Description.Length>2 && car.DailyPrice>0)
            //{
            //    _car.Add(car);
            //    return new SuccessResult(Messages.CarAdded);
            //}

            //return new ErrorResult(Messages.InvalidCarAdded);
        }

        public IResult Delete(Car car)
        {
            _car.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new SuccessDataResult<List<Car>>(_car.GetByAll(), Messages.CarListed);
            //}
            return new SuccessDataResult<List<Car>>(_car.GetAll(), Messages.CarListed);
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Add")]
        public IResult Update(Car car)
        {
            _car.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_car.GetCarDetails());
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
           return new SuccessDataResult<List<Car>>(_car.GetAll(c => c.BrandId == id), Messages.CarListedByBrandId);
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_car.GetAll(c => c.ColorId == id),Messages.CarListedByColorId);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);

            return null;
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            ColorManager colorManager = new ColorManager(new EfColorDal());

            
            
            //BrandAdd(brandManager);

            //BrandUpdate(brandManager);

            //BrandDelete(brandManager);

            //Delete(carManager);

            //Update(carManager);

            //Add(carManager);

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.CarName + "/" + c.BrandName + "/" + c.ColorName + "/" + c.DailyPrice);
            }
        }

        private static void BrandDelete(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { Id = 2, Name = "fsdsa" });
        }

        private static void BrandUpdate(BrandManager brandManager)
        {
            brandManager.Update(new Brand { Id = 2, Name = "fsdsa" });
        }

        private static void BrandAdd(BrandManager brandManager)
        {
            brandManager.Add(new Brand { Id = 2, Name = "bmw" });
        }

        private static void Add(CarManager carManager)
        {
            carManager.Add(new Car
            {
                Id = 5,
                BrandId = 1,
                ColorId = 5,
                DailyPrice = 1400,
                Description = "Tesla",
                ModelYear = "2020"
            });
        }

        private static void Update(CarManager carManager)
        {
            carManager.Update(new Car
            {
                Id = 5,
                BrandId = 10,
                ColorId = 4,
                DailyPrice = 1400,
                Description = "Ferari",
                ModelYear = "2023"
            });
        }

        private static void Delete(CarManager carManager)
        {
            carManager.Delete(new Car
            {
                Id = 5,
                BrandId = 10,
                ColorId = 4,
                DailyPrice = 1400,
                Description = "Ferari",
                ModelYear = "2023"
            });
        }
    }
}

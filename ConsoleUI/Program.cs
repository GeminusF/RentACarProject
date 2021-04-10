using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            ColorManager colorManager = new ColorManager(new EfColorDal());

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            brandManager.Add(new Brand { Id = 2 , Name = "Jaguar"});

 

            //rentalManager.Add(new Rental 
            //{ Id = 1 , 
            //  CardId = 1 ,
            //  CustomerId = 1 ,
            //  RentDate = "4.9.2021",
            //  ReturnDate = "4.12.2021"});

            //var result = carManager.Add(new Car
            //{
            //    Id = 8,
            //    BrandId = 1,
            //    ColorId = 7,
            //    DailyPrice = 0,
            //    Description = "f",
            //    ModelYear = "1990"
            //});



            //BrandAdd(brandManager);

            //BrandUpdate(brandManager);

            //BrandDelete(brandManager);

            //Delete(carManager);

            //Update(carManager);

            //Add(carManager);


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
            brandManager.Add(new Brand { Id = 1, Name = "BMW" });
        }

        private static void Add(CarManager carManager)
        {
            carManager.Add(new Car 
            {
                Id = 7,
                BrandId = 1,
                ColorId = 7,
                DailyPrice = 100,
                Description = "zapi",
                ModelYear = "1990"
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

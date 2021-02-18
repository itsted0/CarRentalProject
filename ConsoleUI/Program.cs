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
        {   // Data Transformation Object
            // CarTest();
            // IoC Container
            // BrandTest();
            // ColorTest();
            // CarTest2();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 4, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = new DateTime(2020, 3, 15) });
            Console.WriteLine(result.Message); 

        }


        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("CarName = {0}  BrandName = {1} ColorName = {2}", car.CarName, car.BrandName, car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(2).Data)
            {
                //Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetAllByColorId(1).Data)
            {
                //Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("CarName = {0}  BrandName = {1} ColorName = {2}", car.CarName, car.BrandName, car.ColorName);
            }
        }
    }
}

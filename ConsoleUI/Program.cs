using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(2))
            {
                //Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetAllByColorId(1))
            {
                //Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("CarName = {0}  BrandName = {1} ColorName = {2}", car.CarName, car.BrandName, car.ColorName);
            }
        }
    }
}

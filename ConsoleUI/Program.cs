using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            // IoC Container
            // BrandTest();
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
                Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine(car.Name);
            }

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(("{0}  {2}", car.Description, car.DailyPrice));
            }
        }
    }
}

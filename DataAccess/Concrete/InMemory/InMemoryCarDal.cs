using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{   // Bellekte calisacak sekilde Car sınıfı kodlayacagiz.
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        // Oracle,Sql Server, Postgres, MongoDb
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {Id = 1, BrandId = 1, ColorId = 1, Name = "Bugatti", DailyPrice = 1500, Description = "Perfect Bugatti", ModelYear = 2020},
                new Car {Id = 2, BrandId = 1, ColorId = 1, Name = "Bugatti", DailyPrice = 1500, Description = "Perfect Bugatti", ModelYear = 2020},
                new Car {Id = 3, BrandId = 1, ColorId = 1, Name = "Bugatti", DailyPrice = 1500, Description = "Perfect Bugatti", ModelYear = 2020},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {   // Gonderdigim car id sine sahip olan listedeki car ı bul demek.
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Name = car.Name;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}

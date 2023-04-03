using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=1,CarName="Doblo",DailyPrice=50000,Description="Hatasız",ModelYear=2023 },
                new Car {Id=2,BrandId=2,ColorId=1,CarName="Fluence",DailyPrice=70000,Description="2 parça değişen",ModelYear=2015 }
            };
        }
        public void add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

           Car carToDelete =  _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> Getall()
        {
           return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.Id == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.CarName= car.CarName;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
        }
    }
}

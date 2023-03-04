using DataAccess.Abstract;
using Entities.Concrete;
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
            _cars = new List<Car>  {

                new Car{Id=1, BrandId=1, ColorId=2,DailyPrice=250,ModelYear=2005,Description="SuperB"},
                new Car{Id=2, BrandId=1, ColorId=2,DailyPrice=350,ModelYear=2007,Description="Octavia"},
                new Car{Id=3, BrandId=2, ColorId=3,DailyPrice=450,ModelYear=2009,Description="Golf"},
                new Car{Id=4, BrandId=2, ColorId=1,DailyPrice=550,ModelYear=2010,Description="Jetta"},
                new Car{Id=5, BrandId=3, ColorId=4,DailyPrice=650,ModelYear=1999,Description="Supra"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        
        
        public ICarDal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService, IBrandService, IColorService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        
        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

       

        public void Update(Car car)
        {
            
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

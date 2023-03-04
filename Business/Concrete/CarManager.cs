using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        private bool isCarExist(Car car)
        {
            var carCheck = _carDal.GetById(car.Id);
            if (carCheck!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(Car car)
        {
            if(!isCarExist(car))
            {
                Console.WriteLine("Araba başarıyla eklendi");
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Bu ID de araç var!");
            }
        }

        public void Delete(Car car)
        {
            if (!isCarExist(car)) 
            {
                _carDal.Delete(car);
            }
            else
            {
                Console.WriteLine("Silinmedi! Belirtilen değerede araç bulunmamaktadır");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

       

        public void Update(Car car)
        {
            if (isCarExist(car))
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Güncellenecek araç yok!");
            }
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

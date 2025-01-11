using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using BuyCars.CORE.Services;
using BuyCars.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.SERVICE
{
    public class CarService:ICarService
    {
        private readonly ICarRepository _CarRepository;

        public CarService(ICarRepository carRepository)
        {
            _CarRepository = carRepository;
        }
        public List<Car> GetList()
        {
            return _CarRepository.getList();
        }
       public List<Car> GetSold()
        {
            return _CarRepository.GetSold();
        }
        public Car GetById(int id)
        {
            return _CarRepository.GetById(id);
        }
        public List<Car> GetBycompany(string company)
        {
            return _CarRepository.GetBycompany(company);
        }
        public void Post(Car c)
        {
           _CarRepository.Post(c);
        }
        public void Put(int id, string? company, double price)
        {
            _CarRepository.Put(id, company, price);
        }
    }
}

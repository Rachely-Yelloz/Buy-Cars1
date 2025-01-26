
using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using BuyCars.CORE.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyCars.SERVICE
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<Car>> GetListAsync()
        {
            return await _carRepository.GetListAsync();
        }

        public async Task<List<Car>> GetSoldAsync()
        {
            return await _carRepository.GetSoldAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _carRepository.GetByIdAsync(id);
        }

        public async Task<List<Car>> GetByCompanyAsync(string company)
        {
            return await _carRepository.GetByCompanyAsync(company);
        }

        public async Task PostAsync(Car c)
        {
            await _carRepository.PostAsync(c);
        }

        public async Task PutAsync(int id, string? company, double price)
        {
            await _carRepository.PutAsync(id, company, price);
        }
    }
}

using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Repositories
{
    public interface ICarRepository
    {
        Task<List<Car>> GetListAsync();
        Task<List<Car>> GetSoldAsync();
        Task<Car> GetByIdAsync(int id);
        Task<List<Car>> GetByCompanyAsync(string company);
        Task PostAsync(Car c);
        Task PutAsync(int id, string? company, double price);
    }
}

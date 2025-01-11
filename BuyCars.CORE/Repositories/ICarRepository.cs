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
        List<Car> getList();
        List<Car> GetSold();
        Car GetById(int id);
        List<Car> GetBycompany(string company);
        void Post( Car c);
        void Put(int id, string? company, double price);
    }
}

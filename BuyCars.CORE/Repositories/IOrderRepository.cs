using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Repositories
{
    public interface IOrderRepository
    {
        List<Order> getList();
       Order Get(int id);
        List<Order> Getbyid(Castomer cas);
        void Post(Order order);
        void Put(int id, DateTime d);
         void Delete(int id);
    }
}

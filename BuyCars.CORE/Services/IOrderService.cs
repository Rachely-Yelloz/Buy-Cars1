
using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyCars.CORE.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetListAsync();
        Task<Order> GetAsync(int id);
        Task<List<Order>> GetByCustomerIdAsync(Castomer customer);
        Task PostAsync(Order order);
        Task PutAsync(int id, DateTime date);
        Task DeleteAsync(int id);
    }
}

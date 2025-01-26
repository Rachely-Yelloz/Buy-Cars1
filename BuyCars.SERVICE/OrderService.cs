
using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using BuyCars.CORE.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyCars.SERVICE
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<List<Order>> GetListAsync()
        {
            return await _OrderRepository.GetListAsync();
        }

        public async Task<Order> GetAsync(int id)
        {
            return await _OrderRepository.GetAsync(id);
        }

        public async Task<List<Order>> GetByCustomerIdAsync(Castomer customer)
        {
            return await _OrderRepository.GetByCustomerIdAsync(customer);
        }

        public async Task PostAsync(Order order)
        {
            await _OrderRepository.PostAsync(order);
        }

        public async Task PutAsync(int id, DateTime date)
        {
            await _OrderRepository.PutAsync(id, date);
        }

        public async Task DeleteAsync(int id)
        {
            await _OrderRepository.DeleteAsync(id);
        }
    }
}


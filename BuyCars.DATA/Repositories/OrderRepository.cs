
using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using Microsoft.EntityFrameworkCore; // ודא שאתה כולל את ה-namespace הזה
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Order>> GetListAsync()
        {
            return await _dataContext.orders.ToListAsync();
        }

        public async Task<Order> GetAsync(int id)
        {
            return await _dataContext.orders.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<List<Order>> GetByCustomerIdAsync(Castomer customer)
        {
            return await _dataContext.orders
                .Where(o => o.Castomer.id == customer.id)
                .ToListAsync();
        }

        public async Task PostAsync(Order order)
        {
            await _dataContext.orders.AddAsync(new Order() { dateOfOrder = order.dateOfOrder, Castomer = order.Castomer, Car = order.Car });
            await _dataContext.SaveChangesAsync();
        }

        public async Task PutAsync(int id, DateTime date)
        {
            var order = await _dataContext.orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                order.dateOfOrder = date;
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _dataContext.orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                _dataContext.orders.Remove(order);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
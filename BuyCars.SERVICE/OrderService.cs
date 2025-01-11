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
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
        public List<Order> GetList()
        {
            return _OrderRepository.getList();
        }
        public Order Get(int id)
        {
            return _OrderRepository.Get(id);
        }
        public List<Order> Getbyid(Castomer cas)
        {
            return _OrderRepository.Getbyid(cas);
        }
        public void Post(Order order)
        {
            _OrderRepository.Post(order);
        }
        public void Put(int id, DateTime d)
        {
            _OrderRepository.Put(id, d);
        }
        public void Delete(int id) { 
        _OrderRepository.Delete(id);
        }


}
}

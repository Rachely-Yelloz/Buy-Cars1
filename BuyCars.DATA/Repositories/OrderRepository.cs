using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> getList()
        {
            return _dataContext.orders.ToList();
        }
        public Order Get(int id)
        {
            foreach (var item in _dataContext.orders.ToList()) 
            { if (item.Id == id) return item; }
            return null;
        }
        public List<Order> Getbyid(Castomer cas)
        {
            List<Order> l = new List<Order>();
            foreach (var item in _dataContext.orders.ToList()) 
            { if (item.Castomer.id == cas.id) l.Add(item); }
            return l;
        }
        public void Post(Order order)
        {
            _dataContext.orders .Add(new Order() { dateOfOrder =order.dateOfOrder, Castomer = order.Castomer, Car = order.Car });
            _dataContext.SaveChanges();

        }
        public void Put(int id, DateTime d)
        {

            for (int i = 0; i < _dataContext.orders.ToList().Count; i++)
            {
                if (_dataContext.orders.ToList()[i].Id == id)
                {
                    _dataContext.orders.ToList()[i].dateOfOrder = d;
                    _dataContext.SaveChanges();

                }
            }
        }
        public void Delete(int id)
        {

            for (int i = 0; i < _dataContext.orders.ToList().Count; i++)
            {
                if (_dataContext.orders.ToList()[i].Id == id) 
                { _dataContext.orders.ToList().RemoveAt(i);
                    _dataContext.SaveChanges();
                }
            }
        }
    }
}

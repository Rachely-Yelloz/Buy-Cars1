using AutoMapper;
using BuyCars.API.Models;
using BuyCars.CORE.DTOs;
using BuyCars.CORE.Models;
using BuyCars.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyCars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _ordersService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService ordersService, IMapper mapper)
        {
            _ordersService = ordersService;
            _mapper = mapper;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<IEnumerable<OrderDTO>> Get()
        {
            var orders = await _ordersService.GetListAsync();
            var res = new List<OrderDTO>();
            foreach (var o in orders)
            {
                res.Add(_mapper.Map<OrderDTO>(o));
            }
            return res;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<OrderDTO> Get(int id)
        {
            var order = await _ordersService.GetAsync(id);
            return _mapper.Map<OrderDTO>(order);
        }

        // GET api/<OrdersController>/customer/{idofper}
        [HttpGet("customer/{idofper}")]
        public async Task<IEnumerable<OrderDTO>> GetByCustomerId(Castomer customer)
        {
            var orders = await _ordersService.GetByCustomerIdAsync(customer);
            var res = new List<OrderDTO>();
            foreach (var o in orders)
            {
                res.Add(_mapper.Map<OrderDTO>(o));
            }
            return res;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task Post(OrdersPostModel order)
        {
            var orderEntity = new Order()
            {
                dateOfOrder = order.dateOfOrder,
                Car = new Car() { Id = order.Car },
                Castomer = new Castomer() { id = order.Castomer }
            };
            await _ordersService.PostAsync(orderEntity);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, DateTime d)
        {
            await _ordersService.PutAsync(id, d);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _ordersService.DeleteAsync(id);
        }
    }
}

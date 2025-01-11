using AutoMapper;
using BuyCars.API.Models;
using BuyCars.CORE.DTOs;
using BuyCars.CORE.Models;
using BuyCars.CORE.Services;
using BuyCars.SERVICE;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public IEnumerable<OrderDTO> Get()
        {
            var order = _ordersService.GetList();
            List<OrderDTO> res = new List<OrderDTO>();
            foreach (var o in order)
            {
                res.Add(_mapper.Map<OrderDTO>(o));
            }
            return res;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public OrderDTO Get(int id)
        {             
             var o=_ordersService.Get(id);
            return _mapper.Map<OrderDTO>(o);
        }

        // POST api/<OrdersController>
        [HttpGet("customer/{idofper}")]
        public IEnumerable<OrderDTO> Getbyid(Castomer castomer)
        {
            var order = _ordersService.GetList();
            List<OrderDTO> res = new List<OrderDTO>();
            foreach (var o in order)
            {
                if(o.Castomer.id == castomer.id)
                    res.Add(_mapper.Map<OrderDTO>(o));
            }
            return res;
        }

        // PUT api/<OrdersController>/5
        [HttpPost]
        public void Post(OrdersPostModel order)
        {
            Order order1 = new Order() { dateOfOrder = order.dateOfOrder, Car = new Car() { Id = order.Car }, Castomer = new Castomer() { id = order.Castomer } };
            _ordersService.Post(order1);
        }
        [HttpPut("{id}")]
        public void Put(int id, DateTime d)
        {
            _ordersService.Put(id, d);
        }
        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ordersService.Delete(id);
        }
    }
}

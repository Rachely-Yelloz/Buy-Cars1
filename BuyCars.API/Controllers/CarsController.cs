using BuyCars.API.Models;
using BuyCars.CORE.Models;
using BuyCars.CORE.Services;
using BuyCars.SERVICE;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuyCars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carService.GetList();
        }

        // GET api/<CarsController>/5
        [HttpGet("sold")]
        public IEnumerable<Car> GetSold() {
        return _carService.GetSold();
        }

        [HttpGet("{id}")]
        public Car GetById(int id) { 
        return _carService.GetById(id);
        }

        [HttpGet("company/{company}")]
        public List<Car> GetBycompany(string company)
        {
            return _carService.GetBycompany(company);
        }

        // DELETE api/<CarsController>/5
        [HttpPost]
        public void Post([FromBody]CarPostModel c)
        {
            Car car = new Car() { Company = c.Company, Price = c.Price, status = true };
            _carService.Post(car);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string? company, double price)
        {
            _carService.Put(id, company, price);
        }
    }
}

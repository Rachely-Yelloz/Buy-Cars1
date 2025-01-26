using BuyCars.API.Models;
using BuyCars.CORE.Models;
using BuyCars.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Car>> Get()
        {
            return await _carService.GetListAsync();
        }

        // GET api/<CarsController>/sold
        [HttpGet("sold")]
        public async Task<IEnumerable<Car>> GetSold()
        {
            return await _carService.GetSoldAsync();
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public async Task<Car> GetById(int id)
        {
            return await _carService.GetByIdAsync(id);
        }

        // GET api/<CarsController>/company/{company}
        [HttpGet("company/{company}")]
        public async Task<List<Car>> GetByCompany(string company)
        {
            return await _carService.GetByCompanyAsync(company);
        }

        // POST api/<CarsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CarPostModel c)
        {
            Car car = new Car() { Company = c.Company, Price = c.Price, status = true };
            await _carService.PostAsync(car);
            return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string? company, double price)
        {
            await _carService.PutAsync(id, company, price);
            return NoContent();
        }
    }
}

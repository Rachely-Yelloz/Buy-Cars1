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
    public class CastomerController : ControllerBase
    {
        private readonly ICastomerService _CastomerService;

        public CastomerController(ICastomerService castomerService)
        {
            _CastomerService = castomerService;
        }

        // GET: api/<CastomerController>
        [HttpGet]
        public IEnumerable<Castomer> Get()
        {
            return _CastomerService.GetList();
        }

        // GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public Castomer Get(int id)
        {
            return _CastomerService.Get(id); 
        }

        // POST api/<CastomerController>
        [HttpPost]
        public void Post(CastomerPostModel castomer)
        {
            Castomer c = new Castomer() { name = castomer.name, phone = castomer.phone };
            _CastomerService.Post(c);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name, string phone)
        {
            _CastomerService.Put(id, name, phone);
        }

        [HttpPut("phone/{phone}")]
        public void PutOnlyPhone(int id, string phone)
        {
            _CastomerService.PutOnlyPhone(id, phone);
        }
        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _CastomerService.Delete(id);
        }
    }
}

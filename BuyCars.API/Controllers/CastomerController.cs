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
        public async Task< IEnumerable<Castomer>> GetAsync()
        {
            return await _CastomerService.GetListAsync();
        }

        // GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public async Task<Castomer> GetAsync(int id)
        {
            return await _CastomerService.GetAsync(id); 
        }

        // POST api/<CastomerController>
        [HttpPost]
        public async Task PostAsync([FromBody] CastomerPostModel castomer)
        {
            Castomer c = new Castomer() { name = castomer.name, phone = castomer.phone };
            await _CastomerService.PostAsync(c);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] string name, string phone)
        {
            await _CastomerService.PutAsync(id, name, phone);
        }

        [HttpPut("phone/{phone}")]
        public async Task PutOnlyPhoneAsync(int id, string phone)
        {
          await  _CastomerService.PutOnlyPhoneAsync(id, phone);
        }
        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
           await _CastomerService.DeleteAsync(id);
        }
    }
}

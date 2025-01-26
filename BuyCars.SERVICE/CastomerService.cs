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
    public class CastomerService:ICastomerService
    {
        private readonly ICastomerRepository _CastomerRepository;

        public CastomerService(ICastomerRepository CastomerRepository)
        {
            _CastomerRepository = CastomerRepository;
        }
        public async Task< List<Castomer>> GetListAsync()
        {
            return await _CastomerRepository.getListAsync();
        }
        public async Task< Castomer> GetAsync(int id)
        {
            return await _CastomerRepository.GetAsync(id);
        }
        public async Task PostAsync(Castomer castomer)
        {
           await _CastomerRepository.PostAsync(castomer);
        }
        public async Task PutAsync(int id, string name, string phone)
        {
          await  _CastomerRepository.PutAsync(id, name, phone);
        }
        public async Task PutOnlyPhoneAsync(int id, string phone)
        {
          await  _CastomerRepository.PutOnlyPhoneAsync(id, phone);
        }
        public async Task DeleteAsync(int id)
        {
          await  _CastomerRepository.DeleteAsync(id);
        }
    }
}

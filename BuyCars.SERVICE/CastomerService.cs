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
        public List<Castomer> GetList()
        {
            return _CastomerRepository.getList();
        }
        public Castomer Get(int id)
        {
            return _CastomerRepository.Get(id);
        }
        public void Post(Castomer castomer)
        {
            _CastomerRepository.Post(castomer);
        }
        public void Put(int id, string name, string phone)
        {
            _CastomerRepository.Put(id, name, phone);
        }
        public void PutOnlyPhone(int id, string phone)
        {
            _CastomerRepository.PutOnlyPhone(id, phone);
        }
        public void Delete(int id)
        {
            _CastomerRepository.Delete(id);
        }
    }
}

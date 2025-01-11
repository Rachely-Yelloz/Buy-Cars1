using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Repositories
{
    public interface ICastomerRepository
    {
        List<Castomer> getList();
       Castomer Get(int id);
        void Post(Castomer castomer);
        void Put(int id, string name, string phone);
        void PutOnlyPhone(int id, string phone);
        void Delete(int id);
    }
}

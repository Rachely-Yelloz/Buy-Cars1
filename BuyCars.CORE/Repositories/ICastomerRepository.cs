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
        Task<List<Castomer>> getListAsync();
        Task<Castomer> GetAsync(int id);
        Task PostAsync(Castomer castomer);
        Task PutAsync(int id, string name, string phone);
        Task PutOnlyPhoneAsync(int id, string phone);
        Task DeleteAsync(int id);
    }
}

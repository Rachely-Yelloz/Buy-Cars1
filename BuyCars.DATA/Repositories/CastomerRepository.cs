using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class CastomerRepository : ICastomerRepository
    {
        private readonly DataContext _dataContext;

        public CastomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Castomer>> getListAsync()
        {
            return await Task.Run(() => _dataContext.castomers.ToList());
        }

        public async Task<Castomer> GetAsync(int id)
        {
            return await _dataContext.castomers
                .FirstOrDefaultAsync(castomer => castomer.id == id);
        }

        public async Task PostAsync(Castomer castomer)
        {
            _dataContext.castomers.ToList().Add(new Castomer() { name = castomer.name, phone = castomer.phone });
           await _dataContext.SaveChangesAsync();

        }
        public async Task PutAsync(int id, string name, string phone)
        {
            var castomer = await _dataContext.castomers
                .FirstOrDefaultAsync(c => c.id == id);

            if (castomer == null)
            {
                return; 
            }

            castomer.name = name;
            castomer.phone = phone;

            await _dataContext.SaveChangesAsync();
        }
        public async Task PutOnlyPhoneAsync(int id, string phone)
        {
            var castomer = await _dataContext.castomers
                .FirstOrDefaultAsync(c => c.id == id);
            if (castomer == null)
                return;
            castomer.phone = phone;
            await _dataContext.SaveChangesAsync();

        }
        public async Task DeleteAsync(int id)
        {
            var castomer = await _dataContext.castomers
                .FirstOrDefaultAsync(c => c.id == id);

            if (castomer == null)
            {
                return; 
            }

            _dataContext.castomers.Remove(castomer);

            await _dataContext.SaveChangesAsync();
        }
    }
}

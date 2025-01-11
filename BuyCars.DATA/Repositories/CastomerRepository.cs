using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class CastomerRepository:ICastomerRepository
    {
        private readonly DataContext _dataContext;

        public CastomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Castomer> getList()
        {
            return _dataContext.castomers.ToList();
        }
        public Castomer Get(int id)
        {
            foreach (Castomer castomer in _dataContext.castomers.ToList())
            {
                if(castomer.id==id)
                    return castomer;
            }
            return null;
        }
        public void Post(Castomer castomer)
        {
            _dataContext.castomers.ToList().Add(new Castomer() { name=castomer.name, phone=castomer.phone });
            _dataContext.SaveChanges();

        }
        public void Put(int id,string name, string phone)
        {

            for (int i = 0; i < _dataContext.castomers.ToList().Count; i++)
            {
                if (_dataContext.castomers.ToList()[i].id == id)
                {
                    _dataContext.castomers.ToList()[i].name = name;
                    _dataContext.castomers.ToList()[i].phone = phone;
                    _dataContext.SaveChanges();

                    return;
                }
            }
        }
        public void PutOnlyPhone(int id, string phone)
        {
            for (int i = 0; i < _dataContext.castomers.ToList().Count; i++)
            {
                if (_dataContext.castomers.ToList()[i].id == id)
                {
                    _dataContext.castomers.ToList()[i].phone = phone;
                    _dataContext.SaveChanges();

                    return;
                }
            }
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _dataContext.castomers.ToList().Count; i++)
            {
                if (_dataContext.castomers.ToList()[i].id == id)
                {
                    _dataContext.castomers.ToList().RemoveAt(i);
                    return;
                }

            }
            _dataContext.SaveChanges();

        }
    }
}

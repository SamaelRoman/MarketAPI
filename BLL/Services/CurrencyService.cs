using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CurrencyService : ICurrencyService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;

        public CurrencyService(IUnitOfWork _contextDb, IMapper _mapper)
        {
            this._contextDb = _contextDb;
            this._mapper = _mapper;
        }
        public void Add(CurrencyDTO entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Currencies.Add(_mapper.Map<Currency>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public void Delete(int ID)
        {
            try
            {
                _contextDb.Currencies.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }
        }

        public void Edit(CurrencyDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Currencies.Edit(_mapper.Map<Currency>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<CurrencyDTO> Get()
        {
            return _mapper.Map<IEnumerable<CurrencyDTO>>(_contextDb.Currencies.Get());
        }

        public CurrencyDTO Get(int ID)
        {
            return _mapper.Map<CurrencyDTO>(_contextDb.Currencies.Get(ID));
        }
    }
}

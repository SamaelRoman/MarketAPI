using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ParameterService : IParameterService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;

        public ParameterService(IUnitOfWork _contextDb, IMapper _mapper)
        {
            this._contextDb = _contextDb;
            this._mapper = _mapper;
        }
        public void Add(ParameterNameDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.ParameterNames.Add(_mapper.Map<ParameterName>(entity));
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
                _contextDb.ParameterNames.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }
        }

        public void Edit(ParameterNameDTO entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.ParameterNames.Edit(_mapper.Map<ParameterName>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ParameterNameDTO> Get()
        {
            return _mapper.Map<IEnumerable<ParameterNameDTO>>(_contextDb.ParameterNames.Get());
        }

        public ParameterNameDTO Get(int ID)
        {
            return _mapper.Map<ParameterNameDTO>(_contextDb.ParameterNames.Get(ID));
        }
    }
}

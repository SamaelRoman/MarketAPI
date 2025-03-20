using AutoMapper;
using Azure;
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
    public class BrandService : IBrandService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;
        public BrandService(IUnitOfWork _contextDb, IMapper _mapper)
        {
            this._contextDb = _contextDb;
            this._mapper = _mapper;
        }

        public void Add(BrandDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Brands.Add(_mapper.Map<Brand>(entity));
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
                _contextDb.Brands.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }

        }

        public void Edit(BrandDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Brands.Edit(_mapper.Map<Brand>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<BrandDTO> Get()
        {
            return _mapper.Map<IEnumerable<BrandDTO>>(_contextDb.Brands.Get());
        }

        public BrandDTO Get(int ID)
        {
            return _mapper.Map<BrandDTO>(_contextDb.Brands.Get(ID));  
        }
    }
}

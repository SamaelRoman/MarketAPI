using AutoMapper;
using Azure;
using BLL.DTO;
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
    public class ProductService : IProductService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;
        public ProductService(IUnitOfWork _contextDb,IMapper _mapper)
        {
            this._contextDb = _contextDb;
            this._mapper = _mapper;
        }
        public void Add(ProductDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Products.Add(_mapper.Map<Product>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Guid ID)
        {
            try
            {
                _contextDb.Products.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }
        }

        public void Edit(ProductDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Products.Edit(_mapper.Map<Product>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ProductDTO> Get()
        {
            return _mapper.Map<IEnumerable<ProductDTO>>(_contextDb.Products.Get());
        }

        public ProductDTO Get(Guid ID)
        {
            return _mapper.Map<ProductDTO>(_contextDb.Products.Get(ID));
        }

        public IEnumerable<ProductContainerDTO> GetAllProductsByGroup(int LangId)
        {
            return _mapper.Map<IEnumerable<ProductContainerDTO>>(_contextDb.Products.GetAllProductsByGroup(LangId));
        }
        public IEnumerable<ProductDTO> GetAllByLanguageId(int LangId)
        {
            return _mapper.Map<IEnumerable<ProductDTO>>(_contextDb.Products.GetAllByLanguageId(LangId));
        }

        public IEnumerable<ProductContainerDTO> GetAllProductsByСategory(int CategoryId)
        {
            return _mapper.Map<IEnumerable<ProductContainerDTO>>(_contextDb.Products.GetAllProductsByСategory(CategoryId));
        }
    }
}

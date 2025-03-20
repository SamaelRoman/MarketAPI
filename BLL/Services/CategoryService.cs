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
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;
        public CategoryService(IUnitOfWork _contextDb, IMapper _mapper)
        {
            this._contextDb = _contextDb;
            this._mapper = _mapper;
        }
        public void Add(CategoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Categories.Add(_mapper.Map<Category>(entity));
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
                _contextDb.Categories.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }
        }

        public void Edit(CategoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.Categories.Edit(_mapper.Map<Category>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<CategoryDTO> Get()
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(_contextDb.Categories.Get());
        }

        public CategoryDTO Get(int ID)
        {
            return _mapper.Map<CategoryDTO>(_contextDb.Categories.Get(ID));
        }

        public IEnumerable<CategoryDTO> GetAllByLanguageId(int languageId)
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(_contextDb.Categories.GetAllByLanguageId(languageId));
        }
    }
}

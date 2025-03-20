using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ContextDB contextDB;
        public CategoryRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }

        public void Add(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                contextDB.Add(entity);
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
                var currentEntity = contextDB.Categories.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.Categories.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Category entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.Categories.Find(entity.id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.name = entity.name;
                currentEntity.description = entity.description;

                contextDB.Categories.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category Get(int ID)
        {
            return contextDB.Categories.Find(ID);
        }

        public IEnumerable<Category> Get()
        {
            return contextDB.Categories.ToList();
        }

        public IEnumerable<Category> GetAllByLanguageId(int languageId)
        {
            return contextDB.Categories.Where(c => c.languageId == languageId);
        }
    }
}

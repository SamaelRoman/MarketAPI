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

    /// Сделать отдельніе таблиці для характиеристик и их значенний в продлуктах для удобного добавления значиений 
    /// характеристик к продуктам и добавления типов характеристик
    public class BrandRepository : IBrandRepository
    {
        private ContextDB contextDB;
        public BrandRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(Brand entity)
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
                var currentEntity = contextDB.Brands.Find(ID);
                if(currentEntity != null)
                {
                    contextDB.Brands.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.Brands.Find(entity.id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.name = entity.name;
                currentEntity.description = entity.description;

                contextDB.Brands.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand Get(int ID)
        {
            return contextDB.Brands.Find(ID); 
        }

        public IEnumerable<Brand> Get()
        {
            return contextDB.Brands.ToList();
        }
    }
}

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
    public class LanguageRepository : ILanguageRepository
    {
        private ContextDB contextDB;
        public LanguageRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(Language entity)
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
                var currentEntity = contextDB.Languages.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.Languages.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Language entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.Languages.Find(entity.id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.name = entity.name;
                currentEntity.shortName = entity.shortName;

                contextDB.Languages.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Language Get(int ID)
        {
            return contextDB.Languages.Find(ID);
        }

        public IEnumerable<Language> Get()
        {
            return contextDB.Languages.ToList();
        }
    }
}

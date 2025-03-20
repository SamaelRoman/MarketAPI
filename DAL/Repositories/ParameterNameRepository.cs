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
    public class ParameterNameRepository : IParameterNameRepository
    {
        private ContextDB contextDB;
        public ParameterNameRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(ParameterName entity)
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
                var currentEntity = contextDB.ParameterNames.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.ParameterNames.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(ParameterName entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.ParameterNames.Find(entity.Id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.Name = entity.Name;
                currentEntity.LanguageId = entity.LanguageId;

                contextDB.ParameterNames.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ParameterName Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParameterName> Get()
        {
            throw new NotImplementedException();
        }
    }
}

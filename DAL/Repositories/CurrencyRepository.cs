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
    public class CurrencyRepository : ICurrencyRepository
    {
        private ContextDB contextDB;
        public CurrencyRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(Currency entity)
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
                var currentEntity = contextDB.Currencies.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.Currencies.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Currency entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.Currencies.Find(entity.id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.name = entity.name;
                currentEntity.curencyRate = entity.curencyRate;
                currentEntity.currencySymbol = entity.currencySymbol;
                currentEntity.shortName = entity.shortName;
                

                contextDB.Currencies.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Currency Get(int ID)
        {
            return contextDB.Currencies.Find(ID);
        }

        public IEnumerable<Currency> Get()
        {
            return contextDB.Currencies.ToList();
        }
    }
}

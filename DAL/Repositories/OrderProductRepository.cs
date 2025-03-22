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
    public class OrderProductRepository : IOrderProductRepository
    {
        private ContextDB contextDB;
        public OrderProductRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(OrderProduct entity)
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

        public void Delete(Guid ID)
        {
            try
            {
                var currentEntity = contextDB.OrderProducts.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.OrderProducts.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(OrderProduct entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.OrderProducts.Find(entity.id);
                if (currentEntity != null)
                {
                    currentEntity.quantity = entity.quantity;
                    contextDB.Update(currentEntity);
                }
            }
            catch (Exception)
            {
                {
                    throw;
                }
            }
        }

        public OrderProduct Get(Guid ID)
        {
            return contextDB.OrderProducts.Find(ID);
        }

        public IEnumerable<OrderProduct> Get()
        {
            return contextDB.OrderProducts.ToList();
        }
        public IEnumerable<OrderProduct> GetAllByOrderID(Guid ID)
        {
            try
            {
                return contextDB.OrderProducts.Where(op => op.OrderID == ID);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

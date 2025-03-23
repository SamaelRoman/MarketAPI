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
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private ContextDB contextDB;
        public OrderStatusRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(OrderStatus entity)
        {
            if(entity != null)
            {
                try
                {
                    contextDB.OrderStatuses.Add(entity);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Delete(short ID)
        {
            if (ID != 0)
            {
                try
                {
                    contextDB.OrderStatuses.Remove(contextDB.OrderStatuses.FirstOrDefault(x => x.id == ID));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Edit(OrderStatus entity)
        {
            if(entity != null)
            {
                try
                {
                    contextDB.OrderStatuses.Update(entity);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public OrderStatus Get(short ID)
        {
            return contextDB.OrderStatuses.FirstOrDefault(x => x.id == ID);
        }

        public IEnumerable<OrderStatus> Get()
        {
            return contextDB.OrderStatuses.ToList();
        }
    }
}

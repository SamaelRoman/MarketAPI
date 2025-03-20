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
            throw new NotImplementedException();
        }

        public void Delete(short ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(OrderStatus entity)
        {
            throw new NotImplementedException();
        }

        public OrderStatus Get(short ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatus> Get()
        {
            throw new NotImplementedException();
        }
    }
}

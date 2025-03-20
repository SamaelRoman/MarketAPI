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
    public class OrderRepository : IOrderRepository
    {
        private ContextDB contextDB;
        public OrderRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }
    }
}

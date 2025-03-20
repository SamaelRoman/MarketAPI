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
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(OrderProduct entity)
        {
            throw new NotImplementedException();
        }

        public OrderProduct Get(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderProduct> Get()
        {
            throw new NotImplementedException();
        }
    }
}

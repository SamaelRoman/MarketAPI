using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderProductRepository : IRepository<OrderProduct,Guid>
    {
        public IEnumerable<OrderProduct> GetAllByOrderID(Guid ID);
    }
}

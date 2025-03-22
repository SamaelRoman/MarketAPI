using BLL.Entities;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IOrderProductService : IService<OrderProductDTO,Guid>
    {
        public IEnumerable<OrderProductDTO> GetAllByOrderID(Guid ID);
    }
}

using BLL.Entities;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductContainerDTO
    {
        public Guid bindingID { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}

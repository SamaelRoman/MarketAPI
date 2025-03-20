using BLL.DTO;
using BLL.Entities;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductService :IService<ProductDTO,Guid>
    {
        IEnumerable<ProductContainerDTO> GetAllProductsByGroup(int LangId);
        IEnumerable<ProductDTO> GetAllByLanguageId(int LangId);
        IEnumerable<ProductContainerDTO> GetAllProductsByСategory(int CategoryId);
    }
}

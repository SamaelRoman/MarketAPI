using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product,Guid>
    {
        public IEnumerable<ProductContainer> GetAllProductsByGroup(int groupBindingID);
        public IEnumerable<Product> GetAllByLanguageId(int LangId);
        IEnumerable<ProductContainer> GetAllProductsByСategory(int CategoryId);
    }
}

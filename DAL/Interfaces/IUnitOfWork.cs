using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBrandRepository Brands { get; }
        public ICategoryRepository Categories { get; }
        public ICurrencyRepository Currencies { get; }
        public ILanguageRepository Languages { get; }
        public IOrderProductRepository OrderProducts { get; }
        public IOrderRepository Orders { get; }
        public IOrderStatusRepository OrderStatuses { get; }
        public IPorductIMGRepository PorductIMGs { get; }
        public IProductRepository Products { get; }
        public IUserRepository Users { get; }
        public IParameterNameRepository ParameterNames { get; }
        public IParameterValueRepository ParameterValues { get; }
        public void SaveChanges();
    }
}

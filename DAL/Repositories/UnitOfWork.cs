using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;
        private ContextDB _contextDB;

        public UnitOfWork(string connectionString)
        {
            _contextDB = new ContextDB(connectionString);    
        }

        private IBrandRepository _brandRepository { get; set; }
        private ICategoryRepository _categoryRepository { get; set; }
        private ICurrencyRepository _currencyRepository { get; set; }
        private ILanguageRepository _languageRepository { get; set; }
        private IOrderProductRepository _orderProductRepository { get; set; }
        private IOrderRepository _orderRepository { get; set; }
        private IOrderStatusRepository _orderStatusRepository { get; set; }
        private IPorductIMGRepository _porductIMGRepository { get; set; }
        private IProductRepository _productRepository { get; set; }
        private IUserRepository _userRepository { get; set; }
        private IParameterValueRepository _parameterValueRepository { get; set; }
        private IParameterNameRepository _parameterNameRepository { get; set; }

        public IBrandRepository Brands
        {
            get
            { 
                if(_brandRepository == null)
                {
                    _brandRepository = new BrandRepository(_contextDB);
                }
                return _brandRepository; 
            }
        }        
        public ICategoryRepository Categories
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_contextDB);
                }
                return _categoryRepository;
            }
        }

        public ICurrencyRepository Currencies
        {
            get
            {
                if (_currencyRepository == null)
                {
                    _currencyRepository = new CurrencyRepository(_contextDB);
                }
                return _currencyRepository;
            }
        }
        public ILanguageRepository Languages
        {
            get
            {
                if (_languageRepository == null)
                {
                    _languageRepository = new LanguageRepository(_contextDB);
                }
                return _languageRepository;
            }
        }
        public IOrderProductRepository OrderProducts
        {
            get
            {
                if (_orderProductRepository == null)
                {
                    _orderProductRepository = new OrderProductRepository(_contextDB);
                }
                return _orderProductRepository;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_contextDB);
                }
                return _orderRepository;
            }
        }
        public IOrderStatusRepository OrderStatuses
        {
            get
            {
                if (_orderStatusRepository == null)
                {
                    _orderStatusRepository = new OrderStatusRepository(_contextDB);
                }
                return _orderStatusRepository;
            }
        }
        public IPorductIMGRepository PorductIMGs
        {
            get
            {
                if (_porductIMGRepository == null)
                {
                    _porductIMGRepository = new PorductIMGRepository(_contextDB);
                }
                return _porductIMGRepository;
            }
        }
        public IProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_contextDB);
                }
                return _productRepository;
            }
        }
        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_contextDB);
                }
                return _userRepository;
            }
        }

        public IParameterNameRepository ParameterNames
        {

            get
            {
                if(_parameterNameRepository == null)
                {
                    _parameterNameRepository = new ParameterNameRepository(_contextDB);
                }
                return _parameterNameRepository;
            }
        }

        public IParameterValueRepository ParameterValues
        {
            get
            {
                if (_parameterValueRepository == null)
                {
                    _parameterValueRepository = new ParameterValueRepository(_contextDB);
                }
                return _parameterValueRepository;
            }
        }

        public void Dispose()
        {
            if(_disposed == false)
            {
                _contextDB.Dispose();
                _disposed = true;
            }
        }

        public void SaveChanges()
        {
            _contextDB.SaveChanges();
        }
    }
}

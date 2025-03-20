using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ContextDB contextDB;
        public ProductRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(Product entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                contextDB.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Guid ID)
        {
            try
            {
                var currentEntity = contextDB.Products.Find(ID);
                if (currentEntity != null)
                {
                    contextDB.Products.Remove(currentEntity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Product entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                var currentEntity = contextDB.Products.Find(entity.id);

                if (currentEntity == null) { new Exception("Сущность с таким ID в базе данных не обнаружена!"); }

                currentEntity.name = entity.name;
                currentEntity.price = entity.price;
                currentEntity.productIMGs = entity.productIMGs;
                currentEntity.ParameterValues = entity.ParameterValues;
                currentEntity.BrandID = entity.BrandID;
                currentEntity.CategoryID = entity.CategoryID;
                currentEntity.LanguageID = entity.LanguageID;
                currentEntity.groupBindingId = entity.groupBindingId;
                currentEntity.desc = entity.desc;
                currentEntity.count = entity.count;

                contextDB.Products.Update(currentEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product Get(Guid ID)
        {
            var product = contextDB.Products.Find(ID);
            if (product != null) {
                contextDB.Entry(product).Navigation("Language").Load();
                contextDB.Entry(product).Navigation("productIMGs").Load();
                contextDB.Entry(product).Navigation("ParameterValues").Load();
                contextDB.Entry(product).Navigation("Category").Load();
                contextDB.Entry(product).Navigation("Brand").Load();
            }
            return product;
        }

        public IEnumerable<Product> Get()
        {
            return contextDB.Products
                .Include(p => p.Language)
                .Include(p => p.productIMGs)
                .Include(p => p.ParameterValues).ThenInclude(pv => pv.ParameterName)
                .Include(p => p.Category)
                .Include(p => p.Brand).ToList();
        }
        public IEnumerable<Product> GetAllByLanguageId(int LangId)
        {
            return contextDB.Products.Where(p => p.LanguageID == LangId)
                .Include(p => p.Language)
                .Include(p => p.productIMGs)
                .Include(p => p.ParameterValues).ThenInclude(pv => pv.ParameterName)
                .Include(p => p.Category)
                .Include(p => p.Brand);

        }
        ///Подумать о том что бы сгруперовать методы и добавить необязательный параметр needGouping в метод GetAllByLanguageId и в get что бы уменьшить кол-во методов
        public IEnumerable<ProductContainer> GetAllProductsByGroup(int LangId)
        {
            var result = contextDB.Products.Where(p=>p.LanguageID == LangId)
                .Include(p => p.Language)
                .Include(p => p.productIMGs)
                .Include(p => p.ParameterValues).ThenInclude(pv => pv.ParameterName)
                .Include(p => p.Category)
                .Include(p => p.Brand).ToList();

            var groupedresult = result.GroupBy(p => p.groupBindingId).Select(r => new ProductContainer
            {

                bindingID = r.Key,
                Products = r.ToList()

            });
            return groupedresult;
        }

        public IEnumerable<ProductContainer> GetAllProductsByСategory(int CategoryId)
        {
            var result = contextDB.Products.Where(p =>p.CategoryID == CategoryId)
                .Include(p => p.Language)
                .Include(p => p.productIMGs)
                .Include(p => p.ParameterValues).ThenInclude(pv => pv.ParameterName)
                .Include(p => p.Category)
                .Include(p => p.Brand).ToList();

            var groupedresult = result.GroupBy(p => p.groupBindingId).Select(r => new ProductContainer
            {

                bindingID = r.Key,
                Products = r.ToList()

            });
            return groupedresult;
        }
    }
}

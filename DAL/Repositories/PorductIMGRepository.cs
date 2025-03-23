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
    public class PorductIMGRepository : IPorductIMGRepository
    {
        private ContextDB contextDB;
        public PorductIMGRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(ProductIMG entity)
        {
            if(entity != null)
            {
                try
                {
                    contextDB.ProductImages.Add(entity);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void Delete(Guid ID)
        {
            try
            {
                contextDB.ProductImages.Remove(contextDB.ProductImages.FirstOrDefault(x => x.id == ID));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(ProductIMG entity)
        {
            if(entity != null)
            {
                try
                {
                    contextDB.ProductImages.Update(entity);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public ProductIMG Get(Guid ID)
        {
            try
            {
                return contextDB.ProductImages.FirstOrDefault(pi => pi.id == ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ProductIMG> Get()
        {
            try
            {
                return contextDB.ProductImages.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ProductIMG> GetProductIMGsByProductID(Guid productID)
        {
            try
            {
                return contextDB.ProductImages.Where(pi=>pi.product.id == productID).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

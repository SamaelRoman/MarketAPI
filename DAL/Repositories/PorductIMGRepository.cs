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
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductIMG entity)
        {
            throw new NotImplementedException();
        }

        public ProductIMG Get(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductIMG> Get()
        {
            throw new NotImplementedException();
        }
    }
}

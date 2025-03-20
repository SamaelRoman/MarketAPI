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
    public class ParameterValueRepository : IParameterValueRepository
    {
        private ContextDB contextDB;
        public ParameterValueRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(ParameterValue entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(ParameterValue entity)
        {
            throw new NotImplementedException();
        }

        public ParameterValue Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParameterValue> Get()
        {
            throw new NotImplementedException();
        }
    }
}

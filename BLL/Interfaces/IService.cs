using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<TEntity,Tid> where TEntity : class
    {
        public void Add(TEntity entity);
        public IEnumerable<TEntity> Get();
        public TEntity Get(Tid ID);
        public void Edit(TEntity entity);
        public void Delete(Tid ID);
    }
}

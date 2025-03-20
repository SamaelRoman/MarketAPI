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
    internal class UserRepository : IUserRepository
    {
        private ContextDB contextDB;
        public UserRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public void Edit(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}

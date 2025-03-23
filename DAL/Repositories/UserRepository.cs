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
          if(entity != null)
            {
                contextDB.Users.Add(entity);
            }
        }

        public void Delete(Guid ID)
        {
            try
            {
                contextDB.Users.Remove(contextDB.Users.FirstOrDefault(x => x.id == ID));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid ID)
        {
            return contextDB.Users.FirstOrDefault(x => x.id == ID);
        }

        public IEnumerable<User> Get()
        {
            return contextDB.Users.ToList();    
        }
    }
}

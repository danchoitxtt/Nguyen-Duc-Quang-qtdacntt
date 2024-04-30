using System.Collections.Generic;
using System.Linq;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
    public class UserDao
    {
        CoffeeDbContext dbContext = new CoffeeDbContext();

        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public bool Update(User user)
        {
            if (dbContext.Users.Any(u => u.UserName == user.UserName)) {
                return false;
            }

            var old = dbContext.Users.SingleOrDefault(u => u.Id == user.Id);
            old.FullName = user.FullName;
            old.UserName = user.UserName;
            old.Description = user.Description;
            old.Level = user.Level;

            dbContext.SaveChanges();
            return true;
        }

        internal void Delete(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

        internal void Add(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}

using CoffeeManagement.DAO;
using System.Collections.Generic;
using System.Linq;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.BO
{
    public class UserBo
    {
        private UserDao _userDao = new UserDao();
        public static User CurrentUser { get; private set; }
        public bool CheckLogin(string username, string password)
        {
            var uList = _userDao.GetAll();
            CurrentUser = uList.FirstOrDefault(u => u.UserName == username && u.Password == password);
           
            return CurrentUser != null ? true : false;
        }

        public void LogOut()
        {
            CurrentUser = null;
        }

        public List<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public bool Update(User user)
        {
            return _userDao.Update(user);
        }

        internal void Delete(User user)
        {
            _userDao.Delete(user);
        }

        internal void Add(User user)
        {
            _userDao.Add(user);
        }

        internal bool IsUsernameExist(string username)
        {
            return _userDao.GetAll().Any(u => u.UserName.Equals(username));
        }
    }
}

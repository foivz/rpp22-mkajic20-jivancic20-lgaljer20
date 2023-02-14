using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBar
{
    public class UserRepository
    {
        public User GetUser(string username)
        {
            using(var context = new DataBaseModel())
            {
                try
                {
                    return context.Users.First(u => u.Username == username);
                } 
                catch 
                {
                    return null;
                }
            }
        }
        public User GetUserById(int id)
        {
            using (var context = new DataBaseModel())
            {
                try
                {
                    return context.Users.First(u => u.Id == id);
                }
                catch
                {
                    return null;
                }
            }
        }

        public string GetRole(string username)
        {
            using (var context = new DataBaseModel())
            {
                return context.Users.First(u => u.Username == username).Role.Name;
            }
        }
    }
}

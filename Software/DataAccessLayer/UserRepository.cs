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
                var result  = from k in context.Users
                              where k.Username == username
                              select k;

                return result as User;
            }
        }
    }
}

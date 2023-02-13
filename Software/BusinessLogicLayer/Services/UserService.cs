using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        public User GetUserById(int id)
        {
            return new UserRepository().GetUserById(id);
        }
    }
}

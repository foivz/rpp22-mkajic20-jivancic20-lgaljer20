using EntitiesLayer.Entities;
using SmartBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoginService
    {
        public bool CheckCredentials(string username, string password)
        {
            UserRepository repo = new UserRepository();
            var user = repo.GetUser(username);
            if (user != null && password == user.Password)
            {
                LoginUser(user);
                return true;
            }
            return false;
        }

        public int CheckUserRole()
        {
            UserRepository repo = new UserRepository();
            string role = repo.GetRole(CurrentUser.user.Username);
            if(role == "admin")
            {
                return 2;
            } 
            else
            {
                return 1;
            }
        }

        private void LoginUser(User user)
        {
            CurrentUser.user = user;
        }
    }
}

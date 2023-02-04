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
            if (user == null)
            {
                return false;
            }
            else
            {
                return password == user.Password;
            }
        }
    }
}

using EntitiesLayer.Entities;
using SmartBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TwoFactorService
    {
        public User user { get; set; }
        public string Code { get; set; }
        public TwoFactorService(string username) 
        {
            var repo = new UserRepository();
            user = repo.GetUser(username);
        }

        public string GenerateCode()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var codeBytes = new byte[6];
                randomNumberGenerator.GetBytes(codeBytes);
                return Convert.ToBase64String(codeBytes).Substring(0, 6);
            }
        }

    }
}

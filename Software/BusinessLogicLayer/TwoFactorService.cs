using EntitiesLayer.Entities;
using SmartBar;
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLogicLayer
{
    public class TwoFactorService
    {
        public User CurrentUser { get; set; }
        public string Code { get; set; }
        public TwoFactorService(string username) 
        {
            var repo = new UserRepository();
            CurrentUser = repo.GetUser(username);
        }

        public async void SendEmail()
        {
            Code = GenerateCode();
            string message = "Kod za dvofaktorsku autentifikaciju: " + Code;
            string apiKey = "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";

            var client = new HttpClient();
            var content = new StringContent(
                "{\"sender\":" + 
                "{\"name\":\"SmartBar\"," +
                "\"email\":\"mkajic20@student.foi.hr\"}," + 
                "\"to\":[{\"email\":\"" + CurrentUser.Email + 
                "\",\"name\":\"" + CurrentUser.Username + 
                "\"}],\"subject\":\"Dvofaktorska autentifikacija\"," + 
                "\"htmlContent\":\"" + message + "\"}",
                Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("api-key", apiKey);
            await client.PostAsync("https://api.sendinblue.com/v3/smtp/email", content);
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

using EntitiesLayer.Entities;
using SmartBar;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class TwoFactorService
    {
        private User LoggedUser { get; set; }
        private string Code { get; set; }
        private UserRepository repo;
        public TwoFactorService()
        {
            repo = new UserRepository();
            LoggedUser = CurrentUser.user;

        }

        public async Task SendEmail()
        {
            Code = GenerateCode();
            Console.WriteLine(Code);
            string message = "Kod za dvofaktorsku autentifikaciju: " + Code;
            string apiKey = "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";

            var client = new HttpClient();
            var content = new StringContent(
                "{\"sender\":" +
                "{\"name\":\"SmartBar\"," +
                "\"email\":\"mkajic20@student.foi.hr\"}," +
                "\"to\":[{\"email\":\"" + LoggedUser.Email +
                "\",\"name\":\"" + LoggedUser.Username +
                "\"}],\"subject\":\"Dvofaktorska autentifikaciju\"," +
                "\"htmlContent\":\"" + message + "\"}",
                Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("api-key", apiKey);

            HttpResponseMessage response = await client.PostAsync("https://api.brevo.com/v3/smtp/email", content);
            Console.WriteLine("Status code: " + response.StatusCode);
            Console.WriteLine("Response content: " + await response.Content.ReadAsStringAsync());
        }


        public async void SendEmail(OrderForm model)
        {
            string message = "Narudžbenica: " + model.Id +
                "<br>Datum: " + model.Date.ToString().Substring(0, 10) +
                "<br>Naručitelj: " + model.User.Username +
                "<br>Proizvodi: <br>";
            foreach (var item in model.OrderItems)
            {
                message += item.Product.Name +":  "+ item.Amount + " komada<br>";
            }
            string apiKey = "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";

            var client = new HttpClient();
            var content = new StringContent(
                "{\"sender\":" +
                "{\"name\":\"SmartBar\"," +
                "\"email\":\"jivancic20@student.foi.hr\"}," +
                "\"to\":[{\"email\":\"" + LoggedUser.Email +
                "\",\"name\":\"" + model.Supplier.Name +
                "\"}],\"subject\":\"Narudžbenica: " + model.Id +"\"," +
                "\"htmlContent\":\"" + message + "\"}",
                Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("api-key", apiKey);
            await client.PostAsync("https://api.brevo.com/v3/smtp/email", content);
        }

        public int CheckCode(string code)
        {
            if (code != Code)
            {
                return 0;
            }
            else
            {
                string role = repo.GetRole(LoggedUser.Username);
                if (role == "korisnik")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
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

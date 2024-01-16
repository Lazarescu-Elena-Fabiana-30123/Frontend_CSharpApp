using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proiect_SCD
{
    class UserService
    {
        static HttpClient client = new HttpClient();
        

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public User createAccount(User user)
        {
            HttpResponseMessage response = client.GetAsync("/api/user/login").Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<User>(response.Content.ReadAsStringAsync().Result);
            }

            return null;
        }
    

    }
}

using DNPHandin4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNPHandin4.Data.Implementation
{
    public class CloudUserService : IUserService
    {
        public async Task AddUser(User user)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("https://localhost:44345/users", content);

            //string adult2 = await message.Content.ReadAsStringAsync();
            //User adult3 = JsonSerializer.Deserialize<User>(adult2);
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:44345/users?username=" + userName+"&password="+password);
            User result = JsonSerializer.Deserialize<User>(message);
            return result;
        }
    }
}

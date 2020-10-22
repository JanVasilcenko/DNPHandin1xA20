using DNPHandin1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNPHandin1.Data.Implementation
{
    public class CloudAdultService : IAdultsService
    {
        public async Task<Adult> AddAdult(Adult adult)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(adult),Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PutAsync("http://dnp.metamate.me/Adults",content);

            string adult2 = await message.Content.ReadAsStringAsync();
            Adult adult3 = JsonSerializer.Deserialize<Adult>(adult2);
            return adult3;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://dnp.metamate.me/Adults");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task RemoveAdult(int id)
        {
            HttpClient client = new HttpClient();
            string url = "http://dnp.metamate.me/Adults/"+id.ToString();
            HttpResponseMessage response = await client.DeleteAsync(url);
        }
    }
}

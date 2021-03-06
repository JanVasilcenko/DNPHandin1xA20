﻿using DNPHandin4.Data;
using DNPHandin4.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNPHandin4.Data.Implementation
{
    public class CloudAdultService : IAdultsService
    {
        public async Task<Adult> AddAdult(Adult adult)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(adult),Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("https://localhost:44345/adults", content);

            string adult2 = await message.Content.ReadAsStringAsync();
            Adult adult3 = JsonSerializer.Deserialize<Adult>(adult2);
            return adult3;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:44345/adults");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task RemoveAdult(int id)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44345/adults/" + id.ToString();
            HttpResponseMessage response = await client.DeleteAsync(url);
        }
    }
}

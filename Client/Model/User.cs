using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DNPHandin4.Model
{
    public class User
    {
        [NotNull]
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [NotNull]
        [JsonPropertyName("city")]
        public string City { get; set; }
        [NotNull,Range(1,100)]
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [NotNull]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}

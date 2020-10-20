using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace DNPHandin1.Models
{
    public class User
    {
        [NotNull]
        public string UserName { get; set; }
        [NotNull]
        public string City { get; set; }
        [NotNull,Range(1,100)]
        public int Age { get; set; }
        [NotNull]
        public string Password { get; set; }
    }
}

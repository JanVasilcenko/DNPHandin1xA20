using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPHandin1.Models;

namespace DNPHandin1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        void AddUser(User newUser);
    }
}

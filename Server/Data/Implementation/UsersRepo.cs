using DNPHandin1.Data;
using DNPHandin1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServices.DataAccess;

namespace WebServices.Data.Implementation
{
    public class UsersRepo : IUserService
    {
        private AdultsDBContext dbcontext;

        public UsersRepo() 
        {
            this.dbcontext = new AdultsDBContext();
        }
        public async Task AddUser(User newUser)
        {
                await dbcontext.users.AddAsync(newUser);
                await dbcontext.SaveChangesAsync();
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
                User first = dbcontext.users.FirstOrDefault(user => user.UserName.Equals(userName));
                if (first == null)
                {
                    throw new Exception("User not found");
                }

                if (!first.Password.Equals(password))
                {
                    throw new Exception("Incorrect password");
                }
                return first;
        }
    }
}

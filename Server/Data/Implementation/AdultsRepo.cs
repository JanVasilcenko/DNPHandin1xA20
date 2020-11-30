using DNPHandin1.Data;
using DNPHandin1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServices.DataAccess;

namespace WebServices.Data.Implementation
{
    public class AdultsRepo : IAdultsService
    {
        private AdultsDBContext dbcontext;

        public AdultsRepo() 
        {
            this.dbcontext = new AdultsDBContext();
        }

        public async Task<Adult> AddAdult(Adult adult)
        {
                int max = dbcontext.adults.Max(adult => adult.Id);
                adult.Id = (++max);
                dbcontext.adults.Add(adult);
                await dbcontext.SaveChangesAsync();
                return adult;   
        }

        public async Task<IList<Adult>> GetAdults()
        {
                List<Adult> copy = new List<Adult>(dbcontext.adults);
                return copy;
        }

        public async Task RemoveAdult(int id)
        {
                Adult toRemove = dbcontext.adults.First(a => a.Id == id);
                dbcontext.adults.Remove(toRemove);
                await dbcontext.SaveChangesAsync();
        }
    }
}

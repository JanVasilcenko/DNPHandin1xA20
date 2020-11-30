using DNPHandin4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNPHandin4.Data
{
    public interface IAdultsService
    {
        Task<IList<Adult>> GetAdults();
        Task<Adult> AddAdult(Adult adult);
        Task RemoveAdult(int id);
    }
}

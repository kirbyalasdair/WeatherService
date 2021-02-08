using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Models;

namespace IAPI.Domain.Repositories
{
    public interface IMetAreaRepository
    {
        Task<IEnumerable<MetArea>> GetAll();

        Task<MetArea> GetMetArea(int id);

        Task<MetArea> AddCrag(MetArea metArea);
       
    }
}

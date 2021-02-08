using System;
using System.Collections.Generic;
using System.Linq;
using IAPI.Domain.Models;
using System.Threading.Tasks;

namespace IAPI.Domain.Repositories
{
    public interface ICragRepository
    {
        Task<IEnumerable<Crag>> ListAsync();

        Task<Crag> GetCrag(int id);

        Task<Crag> AddCrag(Crag crag);

        Task<Crag> UpdateCrag(Crag crag);

        Task<Crag> DeleteCrag(int id);
    }
}

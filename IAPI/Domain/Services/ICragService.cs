using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Models;


namespace IAPI.Domain.Services
{
    public interface ICragService
    {
        Task<IEnumerable<Crag>> ListAsync();

        Task<Crag> GetCrag(int id);

        Task<Crag> AddCrag(Crag crag);

        Task<Crag> UpdateCrag(Crag crag);

        Task<Crag> DeleteCrag(int id);
    }
}

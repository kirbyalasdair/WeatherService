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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Models;

namespace IAPI.Domain.Services
{
    interface IMetAreaService
    {
        Task<IEnumerable<MetArea>> ListAsync();
    }
}

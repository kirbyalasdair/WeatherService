using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Services;
using IAPI.Domain.Models;
using IAPI.Domain.Repositories;

namespace IAPI.Domain.Services
{
    public class CragService
    {
        private readonly ICragRepository _cragRepository;

        public CragService(ICragRepository cragRepository)
        {
            this._cragRepository = cragRepository;
        }
        public async Task<IEnumerable<Crag>> ListAsync()
        {
            return await _cragRepository.ListAsync();
        }
    }
}

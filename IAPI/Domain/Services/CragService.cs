using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Services;
using IAPI.Domain.Models;
using IAPI.Domain.Repositories;

namespace IAPI.Domain.Services
{
    public class CragService : ICragService
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

        public async Task<Crag> GetCrag(int id)
        {
            return await _cragRepository.GetCrag(id);
        }

        public async Task<Crag> AddCrag(Crag crag)
        {
            return await _cragRepository.AddCrag(crag);
        }

        public async Task<Crag> UpdateCrag(Crag crag)
        {
            return await _cragRepository.UpdateCrag(crag);
        }

        public async Task<Crag> DeleteCrag(int id)
        {
           return await  _cragRepository.DeleteCrag(id);

        }
    }
}

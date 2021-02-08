using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Models;
using IAPI.Domain.Persistance.Repositories;
using IAPI.Domain.Repositories;

namespace IAPI.Domain.Services
{
    public class MetAreaService : IMetAreaService
    {
        private readonly IMetAreaRepository _metAreaRepository;

        public MetAreaService(IMetAreaRepository metAreaRepository)
        {
            this._metAreaRepository = metAreaRepository;
        }

        public async Task<IEnumerable<MetArea>> GetAll()
        {
            return await _metAreaRepository.GetAll();
        }

        public async Task<MetArea> GetMetArea(int id)
        {
            return await _metAreaRepository.GetMetArea(id);
        }

        public async Task<MetArea> AddCrag(MetArea metArea)
        {
            return await _metAreaRepository.AddCrag(metArea);
        }
    }
}

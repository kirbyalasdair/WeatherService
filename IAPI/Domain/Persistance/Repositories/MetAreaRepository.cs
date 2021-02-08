using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IAPI.Domain.Models;
using IAPI.Domain.Repositories;
using IAPI.Domain.Data;

namespace IAPI.Domain.Persistance.Repositories
{
    class MetAreaRepository : BaseRepository, IMetAreaRepository
    {
        public MetAreaRepository(DataContext context) : base(context)
        {

        }

        public async Task<IEnumerable<MetArea>> GetAll()
        {
            return await _dataContext.MetAreas.ToListAsync();
        }
            

        public async Task<MetArea> GetMetArea(int id)
        {
            return await _dataContext.MetAreas.
                FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<MetArea> AddCrag(MetArea metArea)
        {
            var result = await _dataContext.MetAreas.
                FirstOrDefaultAsync(m => m.Id == metArea.Id);

            if (result != null)
            {
                result.Crags = metArea.Crags;
                await _dataContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}

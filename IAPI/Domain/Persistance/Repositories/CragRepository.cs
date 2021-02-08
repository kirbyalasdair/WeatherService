using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IAPI.Domain.Repositories;
using IAPI.Domain.Data;
using IAPI.Domain.Models;

namespace IAPI.Domain.Persistance.Repositories
{
    public class CragRepository : BaseRepository, ICragRepository 
    {
        public CragRepository(DataContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Crag>> ListAsync()
        {
            return await _dataContext.Crags.ToListAsync();
        }

        public async Task<Crag> GetCrag(int id)
        {
            return await _dataContext.Crags.
                FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Crag> AddCrag(Crag crag)
        {
            var result = await _dataContext.Crags.AddAsync(crag);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Crag> UpdateCrag(Crag crag)
        {
            var result = await _dataContext.Crags.
                FirstOrDefaultAsync(c => c.Id == crag.Id);

            if (result != null)
            {
                result.Name = crag.Name;
                result.Directions = crag.Directions;
                result.RockType = crag.RockType;
                result.DryFor = crag.DryFor;
                result.Rating = crag.Rating;
                result.Altitude = crag.Altitude;

                await _dataContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<Crag> DeleteCrag(int id)
        {
            var result = await _dataContext.Crags.
                FirstOrDefaultAsync(c => c.Id == id);
            if (result != null)
            {
                _dataContext.Crags.Remove(result);
                await _dataContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}

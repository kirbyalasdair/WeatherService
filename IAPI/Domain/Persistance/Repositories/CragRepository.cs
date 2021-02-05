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
    }
}

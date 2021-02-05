using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Data;

namespace IAPI.Domain.Persistance.Repositories
{
    public class BaseRepository
    {
        protected readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    }
}

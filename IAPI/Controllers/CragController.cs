using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPI.Domain.Services;
using IAPI.Domain.Models;

namespace IAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CragController : ControllerBase
    {
        private readonly ICragService _cragService;

        public CragController(ICragService cragService)
        {
            _cragService = cragService;
        }

        [HttpGet]
        public async Task<IEnumerable<Crag>> GetAllAsync()
        {
            var crags = await _cragService.ListAsync();
            return crags;
        }
    }
}

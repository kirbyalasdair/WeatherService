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
    public class MetAreaController : ControllerBase
    {
        private readonly IMetAreaService _metAreaService;

        public MetAreaController(IMetAreaService metAreaService)
        {
            _metAreaService = metAreaService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _metAreaService.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreiving");
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MetArea>> GetMetArea(int id)
        {
            try
            {
                var result = await _metAreaService.GetMetArea(id);
                if (result != null)
                {
                    return Ok(result);
                }

                return NotFound();

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreiving from Database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<MetArea>> AddCrag(int id, MetArea metArea)
        {
            try
            {
                if (id != metArea.Id)
                {
                    return BadRequest("Id mismatch");
                }

                var result = await _metAreaService.GetMetArea(id);

                if (result != null)
                {
                    return await _metAreaService.AddCrag(metArea);
                }

                return NotFound($"MetArea with ID = {id} not found");

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error adding crag to metArea");
            }
        }
    }
}

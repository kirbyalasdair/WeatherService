﻿using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _cragService.ListAsync());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreiving");
            }
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Crag>> GetCrag(int id)
        {
            try
            {
                var result = await _cragService.GetCrag(id);
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

        [HttpPost]
        public async Task<ActionResult<Crag>> CreateCrag(Crag crag)
        {
            try
            {
                if (crag == null)
                {
                    return BadRequest();
                }

                var created = await _cragService.AddCrag(crag);

                return CreatedAtAction(nameof(GetCrag),
                    new { id = created.Id }, created);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Crag>> UpdateCrag(int id, Crag crag)
        {
            try
            {
                if (id != crag.Id)
                {
                    return BadRequest("Id mismatch");
                }

                var result = await _cragService.GetCrag(id);

                if (result != null)
                {
                    return await _cragService.UpdateCrag(crag);
                }

                return NotFound($"Crag with ID = {id} not found");

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating crag");
            }
        }
    }
}

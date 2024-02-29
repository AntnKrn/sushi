using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Worker;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/workers")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IWorkerRepository _workerRepo;
        public WorkerController(ApplicationDBContext context, IWorkerRepository workerRepo) 
        {
            _workerRepo = workerRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var workers = await _workerRepo.GetAllAsync();
            
            var workersDto = workers.Select(s => s.ToWorkerDto());

            return Ok(workersDto); //
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)  
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workers = await _workerRepo.GetByIdAsync(id);

            if(workers == null)
            {
                return NotFound();
            }

            return Ok(workers.ToWorkerDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWorkerRequestDto workerDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var workerModel = workerDto.ToWorkerFromCreateDto();
            await _workerRepo.CreateAsync(workerModel);
            return CreatedAtAction(nameof(GetById), new { id = workerModel.Id }, workerModel.ToWorkerDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateWorkerRequestDto updateDto) 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var workerModel = await _workerRepo.UpdateByIdAsync(id, updateDto);

            if(workerModel == null) 
            {
                return NotFound();
            }

            return Ok(workerModel.ToWorkerDto());
        }

        [HttpDelete]
        [Route("{id:int}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var workerModel = await _workerRepo.DeleteAsync(id);


            if(workerModel == null) 
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
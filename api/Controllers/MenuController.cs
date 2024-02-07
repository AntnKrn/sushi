using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Menu;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMenuRepository _menuRepo;
        public MenuController(ApplicationDBContext context, IMenuRepository menuRepo) 
        {
            _menuRepo = menuRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var menu = await _menuRepo.GetAllAsync();
            
            var menuDto = menu.Select(s => s.ToMenuDto());

            return Ok(menuDto); //
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)  
        {
            var menu = await _menuRepo.GetByIDAsync(id);

            if(menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMenuRequestDto menuDto)
        {
            var menuModel = menuDto.ToMenuFromCreateDto();
            await _menuRepo.CreateAsync(menuModel);
            // string json = JsonConvert.SerializeObject(menuModel);
            // Console.WriteLine(json);
            return CreatedAtAction(nameof(GetById), new { id = menuModel.Id }, menuModel.ToMenuDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateMenuRequestDto updateDto) 
        {
            var menuModel = await _menuRepo.UpdateAsync(id, updateDto);

            if(menuModel == null) 
            {
                return NotFound();
            }

            return Ok(menuModel.ToMenuDto());
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var menuModel = await _menuRepo.DeleteAsync(id);


            if(menuModel == null) 
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
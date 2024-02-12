using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Menu;
using api.Helpers.QueryObjects;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationDBContext _context;

        public MenuRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public async Task<List<Menu>> GetAllAsync(MenuQueryObject query) {
            var menu = _context.Menu.AsQueryable();
            
            if(!string.IsNullOrWhiteSpace(query.Type))
            {
                menu = menu.Where(s => s.Type.Contains(query.Type)); 
            }

            return await menu.ToListAsync();
        }

        public async Task<Menu> CreateAsync(Menu menuModel) {
            await  _context.Menu.AddAsync(menuModel);
            await _context.SaveChangesAsync();
            return menuModel;
        }
        public async Task<Menu?> GetByIDAsync(int id) {
            return await _context.Menu.FindAsync(id);
        }

        public async Task<Menu?> DeleteAsync(int id) {
            var menuModel = await _context.Menu.FirstOrDefaultAsync(x => x.Id == id);

            if(menuModel == null) 
            {
                return null;
            }

            _context.Menu.Remove(menuModel);
            await _context.SaveChangesAsync();

            return menuModel;
        }

        public async Task<Menu?> UpdateAsync(int id, UpdateMenuRequestDto menuDto) {
            var existingMenu = await _context.Menu.FirstOrDefaultAsync(x => x.Id == id);

            if(existingMenu == null) 
            {
                return null;
            }

            existingMenu.Name = menuDto.Name;
            existingMenu.Ingredients = menuDto.Ingredients;
            existingMenu.Type = menuDto.Type;
            existingMenu.Price = menuDto.Price;

            await _context.SaveChangesAsync();

            return existingMenu;
        }
    }
}
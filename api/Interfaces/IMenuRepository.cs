using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Menu;
using api.models;

namespace api.Interfaces
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetAllAsync();

        Task<Menu?> GetByIDAsync(int id);

        Task<Menu> CreateAsync(Menu menuModel);

        Task<Menu?> UpdateAsync(int id, UpdateMenuRequestDto menuDto);

        Task<Menu?> DeleteAsync(int id);
    }
}
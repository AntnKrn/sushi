using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Menu;
using api.models;

namespace api.Mappers
{
    public static class MenuMappers
    {
        public static MenuDto ToMenuDto(this Menu menuModel) 
        {
            return new MenuDto 
            {
                Id = menuModel.Id,
                Name = menuModel.Name,
                Ingredients = menuModel.Ingredients,
                Type = menuModel.Type,
                Price = menuModel.Price
            };
        }

        public static Menu ToMenuFromCreateDto(this CreateMenuRequestDto menuDto) 
        {
            return new Menu
            {
                Name = menuDto.Name,
                Ingredients = menuDto.Ingredients,
                Type = menuDto.Type,
                Price = menuDto.Price
            };
        }
    }
}
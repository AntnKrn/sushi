using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/orderItems")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemRepository _orderItemRepo;

        public OrderItemController(IOrderItemRepository orderItemRepo)
        {
            _orderItemRepo = orderItemRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var orderItems = await _orderItemRepo.GetAllAsync();

            var orderItemDto = orderItems.Select(s => s.ToOrderItemDto());

            return Ok(orderItemDto);
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var orderItem = await _orderItemRepo.GetByIDAsync(id);

            if(orderItem == null) 
            {
                return NotFound();
            }

            return Ok(orderItem.ToOrderItemDto());
        }
    }
}
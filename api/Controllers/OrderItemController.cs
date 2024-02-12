using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderItem;
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
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var orderItem = await _orderItemRepo.GetByIDAsync(id);

            if(orderItem == null) 
            {
                return NotFound();
            }

            return Ok(orderItem.ToOrderItemDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderItemRequestDto updateDto) 
        {
            var OrderItem = await _orderItemRepo.UpdateAsync(updateDto.ToOrderItemDtoFromUpdate(), id);

            if(OrderItem == null) 
            {
                return NotFound("OrderItem not found");
            }

            return Ok(OrderItem.ToOrderItemDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var orderItem = await _orderItemRepo.DeleteAsync(id);

            if(orderItem == null) 
            {
                return NotFound("order item not found");
            }

            return NoContent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.OrderItem;
using api.Dtos.Orders;
using api.Interfaces;
using api.Mappers;
using api.models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderRepository _orderRepo;

        public OrderController(IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var order = await _orderRepo.GetByIDAsync(id);

            if(order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var order = await _orderRepo.GetAllAsync();

            var orderDto = order.Select(s => s.ToOrderDto());

            return Ok(orderDto);
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromBody] CreateOrderRequestDto orderDto)
        {
            var orderModel = orderDto.ToOrderFromCreateDto();
            await _orderRepo.CreateAsync(orderModel);

            var orderItemsModel = orderDto.OrderItems;

            foreach (var orderItem in orderItemsModel)
            {
                orderItem.ToOrderItemDtoFromOrder();
            }

            string json = JsonConvert.SerializeObject(orderItemsModel);
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine(json);
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");
            Console.WriteLine("+=++++++++++++++++++++++++++++++++");

            return CreatedAtAction(nameof(GetById), new {id = orderModel.Id}, orderModel.ToOrderDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, UpdateOrderRequestDto updateDto)
        {
            var orderModel = await _orderRepo.UpdateAsync(id, updateDto);

            if(orderModel == null) 
            {
                return NotFound();
            }

            return Ok(orderModel.ToOrderDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var order = await _orderRepo.GetByIDAsync(id);

            if(order == null)
            {
                return NotFound();
            }

            return NoContent();
        }
        
    }
}
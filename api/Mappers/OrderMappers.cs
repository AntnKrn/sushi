using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Orders;
using api.models;

namespace api.Mappers
{
    public static class OrderMappers
    {
        public static OrderDto ToOrderDto(this Order orderModel)
        {
            return new OrderDto {
                Id = orderModel.Id,
                ClientId = orderModel.ClientId,
                Date = orderModel.Date,
                TotalPrice = orderModel.TotalPrice,
                Status = orderModel.Status,
                OrderItems = orderModel.OrderItems.Select(s => s.ToOrderItemDto()).ToList()
            };
        }

        public static Order ToOrderFromCreateDto(this CreateOrderRequestDto orderDto)
        {
            return new Order {
                ClientId = orderDto.ClientId,
                Date = orderDto.Date,
                TotalPrice = orderDto.TotalPrice,
                Status = orderDto.Status
            };
        }
    }
}
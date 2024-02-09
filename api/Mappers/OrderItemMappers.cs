using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderItem;
using api.models;

namespace api.Mappers
{
    public static class OrderItemMappers
    {
        public static OrderItemDto ToOrderItemDto(this OrderItem orderItemModel)
        {
            return new OrderItemDto {
                Id = orderItemModel.Id,
                OrderId = orderItemModel.OrderId,
                ProductId = orderItemModel.ProductId,
                Quantity = orderItemModel.Quantity,
                SubSum = orderItemModel.SubSum,
            };
        }

        public static OrderItem ToOrderItemDtoFromOrder(this CreateOrderItemRequestDto orderItemDto)
        {
            return new OrderItem {
                ProductId = orderItemDto.ProductId,
                Quantity = orderItemDto.Quantity,
                SubSum = orderItemDto.SubSum
            };
        }
    }
}
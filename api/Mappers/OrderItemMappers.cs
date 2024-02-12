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
                MenuId = orderItemModel.MenuId,
                Quantity = orderItemModel.Quantity,
                SubSum = orderItemModel.SubSum,
            };
        }

        public static OrderItem ToOrderItemDtoFromCreateOrder(this CreateOrderItemRequestDto orderItemDto)
        {
            return new OrderItem {
                MenuId = orderItemDto.MenuId,
                Quantity = orderItemDto.Quantity,
                SubSum = orderItemDto.SubSum
            };
        }

        public static OrderItem ToOrderItemDtoFromUpdate(this UpdateOrderItemRequestDto orderItemDto)
        {
            return new OrderItem {
                MenuId = orderItemDto.MenuId,
                Quantity = orderItemDto.Quantity,
                SubSum = orderItemDto.SubSum
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderItem;
using api.models;

namespace api.Interfaces
{
    public interface IOrderItemRepository
    {
        Task<List<OrderItem>> GetAllAsync();

        Task<OrderItem?> GetByIDAsync(int id);

        Task<OrderItem> CreateAsync(CreateOrderItemRequestDto orderItemModel, int id);

        // Task<OrderItem?> UpdateAsync(int id, OrderItem orderItem);

        // Task<OrderItem?> DeleteAsync(int id);
    }
}
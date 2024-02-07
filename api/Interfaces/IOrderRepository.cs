using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Orders;
using api.models;

namespace api.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();

        Task<Order?> GetByIDAsync(int id);

        Task<Order> CreateAsync(Order orderModel);

        Task<Order?> UpdateAsync(int id, UpdateOrderRequestDto orderDto);

        Task<Order?> DeleteAsync(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.OrderItem;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {

        private readonly ApplicationDBContext _context;

        public OrderItemRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<OrderItem> CreateAsync(CreateOrderItemRequestDto orderItemModel, int id)
        {
            var existingOrderItem = new OrderItem() {
                OrderId = id,
                ProductId = orderItemModel.ProductId,
                Quantity = orderItemModel.Quantity,
                SubSum = orderItemModel.SubSum,
            };
            await _context.OrderItems.AddAsync(existingOrderItem);
            await _context.SaveChangesAsync();
            return existingOrderItem;
        }

        public async Task<List<OrderItem>> GetAllAsync()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<OrderItem?> GetByIDAsync(int id)
        {
            return await _context.OrderItems.FindAsync(id);
        }

        
    }
}
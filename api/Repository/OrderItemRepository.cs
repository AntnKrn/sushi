using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.OrderItem;
using api.Interfaces;
using api.models;
using Microsoft.AspNetCore.Http.HttpResults;
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
                MenuId = orderItemModel.MenuId,
                Quantity = orderItemModel.Quantity,
                SubSum = orderItemModel.SubSum,
            };
            await _context.OrderItems.AddAsync(existingOrderItem);
            await _context.SaveChangesAsync();
            return existingOrderItem;
        }

        public async Task<OrderItem?> DeleteAsync(int id)
        {
            var orderItem = await _context.OrderItems.FirstOrDefaultAsync(x => x.Id == id);

            if(orderItem == null)
            {
                return null;
            }

            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();

            return orderItem;
        }

        public async Task<List<OrderItem>> GetAllAsync()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<OrderItem?> GetByIDAsync(int id)
        {
            return await _context.OrderItems.FindAsync(id);
        }

        public async Task<OrderItem?> UpdateAsync(OrderItem orderItemModel, int id)
        {
            var existingOrderItem = await _context.OrderItems.FindAsync(id);

            if(existingOrderItem == null)
            {
                return null;
            }

            existingOrderItem.MenuId = orderItemModel.MenuId;
            existingOrderItem.Quantity = orderItemModel.Quantity;
            existingOrderItem.SubSum = orderItemModel.SubSum;

            await _context.SaveChangesAsync();

            return existingOrderItem;
        }
    }
}
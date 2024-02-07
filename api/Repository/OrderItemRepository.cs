using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
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

        public async Task<OrderItem> CreateAsync(OrderItem orderItemModel)
        {
            await _context.OrderItems.AddAsync(orderItemModel);
            await _context.SaveChangesAsync();
            return orderItemModel;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Orders;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _context;

        public OrderRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public async Task<Order> CreateAsync(Order orderModel)
        {
            await _context.Orders.AddAsync(orderModel);
            await _context.SaveChangesAsync();
            return orderModel;
        }

        public async Task<Order?> DeleteAsync(int id)
        {
            var orderModel = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if(orderModel == null) 
            {
                return null;
            }

            _context.Orders.Remove(orderModel);
            await _context.SaveChangesAsync();

            return orderModel;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.Include(s => s.OrderItems).ToListAsync();
        }

        public async Task<Order?> GetByIDAsync(int id)
        {
            return await _context.Orders.Include(s => s.OrderItems).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Order?> UpdateAsync(int id, UpdateOrderRequestDto orderDto)
        {
            var existingOrder = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if(existingOrder == null)
            {
                return null;
            }

            existingOrder.ClientId = orderDto.ClientId;
            existingOrder.Date = orderDto.Date;
            existingOrder.TotalPrice = orderDto.TotalPrice;
            existingOrder.Status = orderDto.Status;

            await _context.SaveChangesAsync();

            return existingOrder;
        }
    }
}
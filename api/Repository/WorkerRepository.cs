using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Worker;
using api.Interfaces;
using api.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly ApplicationDBContext _context;

        public WorkerRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Worker> CreateAsync(Worker worker)
        {
            await  _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();
            return worker;
        }

        public async Task<Worker?> DeleteAsync(int id)
        {
            var workerItem = await _context.Workers.FirstOrDefaultAsync(x => x.Id == id);

            if(workerItem == null)
            {
                return null;
            }

            _context.Workers.Remove(workerItem);
            await _context.SaveChangesAsync();

            return workerItem;
        }

        public async Task<List<Worker>> GetAllAsync()
        {
            return await _context.Workers.ToListAsync();
        }

        public async Task<Worker?> GetByIdAsync(int id)
        {
            return await _context.Workers.FindAsync(id);
        }

        public async Task<Worker?> UpdateByIdAsync(int id, UpdateWorkerRequestDto workerDto)
        {
            var existingWorker = await _context.Workers.FirstOrDefaultAsync(x => x.Id == id);

            if(existingWorker == null) 
            {
                return null;
            }

            existingWorker.Fullname = workerDto.Fullname;
            existingWorker.Type = workerDto.Type;
            existingWorker.IsOnline = workerDto.IsOnline;

            await _context.SaveChangesAsync();

            return existingWorker;
        }
    }
}
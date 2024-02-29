using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Worker;
using api.Migrations;
using api.models;

namespace api.Interfaces
{
    public interface IWorkerRepository
    {
        Task<List<Worker>> GetAllAsync();
        Task<Worker?> GetByIdAsync(int id);

        Task<Worker?> UpdateByIdAsync(int id, UpdateWorkerRequestDto workerDto);
        Task<Worker?> DeleteAsync(int id);
        Task<Worker> CreateAsync(Worker worker);
    }
}
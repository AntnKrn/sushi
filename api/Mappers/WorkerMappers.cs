using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Worker;
using api.models;

namespace api.Mappers
{
    public static class WorkerMapper
    {
        public static WorkerDto ToWorkerDto(this Worker workerModel) 
        {
            return new WorkerDto 
            {
                Id = workerModel.Id,
                Fullname = workerModel.Fullname,
                Type = workerModel.Type,
                IsOnline = workerModel.IsOnline
            };  
        }

        public static Worker ToWorkerFromCreateDto(this CreateWorkerRequestDto workerDto)
        {
            return new Worker 
            {
                Fullname = workerDto.Fullname,
                Type = workerDto.Type,
                IsOnline = workerDto.IsOnline
            };
        }
    }
}
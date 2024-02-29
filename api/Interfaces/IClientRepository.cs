using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Client;
using api.models;

namespace api.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> CreateAsync(Client clientModel);
        Task<Client?> UpdateAsync(int id, UpdateClientRequestDto clientDto); 
        Task<Client?> GetByIdAsync(string id);
    }
}
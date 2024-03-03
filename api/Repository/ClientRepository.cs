using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Client;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDBContext _context;

        public ClientRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Client?> UpdateAsync(int id, UpdateClientRequestDto clientDto)
        {
            var existingClient = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);

            if(existingClient == null)
            {
                return null;
            }

            existingClient.Fullname = clientDto.Fullname;
            existingClient.PhoneNumber = clientDto.PhoneNumber;
            existingClient.Address = clientDto.Address;

            await _context.SaveChangesAsync();
            return existingClient;
        }

        public async Task<Client> CreateAsync(Client clientModel)
        {
            await _context.Clients.AddAsync(clientModel);
            
            await _context.SaveChangesAsync();
            return clientModel;
        }

        public async Task<Client?> GetByIdAsync(string id)
        {
            return await _context.Clients.FirstOrDefaultAsync(x => x.UserId == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Client;
using api.models;

namespace api.Mappers
{
    public static class ClientMappers
    {
        public static Client ToClientDtoFromCreateDto(this Client clientModel)
        {
            return new Client
            {
                UserId = clientModel.UserId,
            };
        }
    }
}
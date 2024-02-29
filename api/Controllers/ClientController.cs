using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Client;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IClientRepository _clientRepo;

        public ClientController(ApplicationDBContext context, IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
            _context = context;
        }
    }
}
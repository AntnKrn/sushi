using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Client;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IClientRepository _clientRepo;
        private readonly ITokenService _tokenService;

        public ClientController(ApplicationDBContext context, IClientRepository clientRepo, ITokenService tokenService)
        {
            _clientRepo = clientRepo;
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateClientRequestDto updateDto, [FromHeader] string Authorization)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string jwt = Authorization.Remove(0, Authorization.IndexOf(' ') + 1);
            JwtSecurityToken decodedJwt = _tokenService.DecodeJwt(jwt);

            string IdUserFromJwt = decodedJwt.Claims.First(claim => claim.Type == "unique_name").Value;

            if(IdUserFromJwt != id)
            {
                return BadRequest("Unauthorized account");
            }

            var clientModel = await _clientRepo.UpdateAsync(id, updateDto);

            if(clientModel == null)
            {
                return NotFound();
            }

            return Ok(clientModel.ToUpdateClientDto());
        }
    }
}
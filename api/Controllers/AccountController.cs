using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Account;
using api.Interfaces;
using api.models;
using api.Mappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Client;
using api.Service;
using System.Text.Json;
using System.IdentityModel.Tokens.Jwt;


namespace api.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<User> _signInManager;
        private readonly IClientRepository _clientRepo;
        public AccountController(UserManager<User> userManager, 
            ITokenService tokenService, SignInManager<User> signInManager,
            IClientRepository clientRepo
        )
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _clientRepo = clientRepo;
            
        }

        [HttpPost("login")] // antkrn JhQ123iiLo_

        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.UserName.ToLower());

            if(user == null)
            {
                return Unauthorized("Invalid username");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if(!result.Succeeded)
            {
                return Unauthorized("Username not found or a password incorrect");
            }
            List<string> roles = new List<string>(await _userManager.GetRolesAsync(user));

            return Ok(
                new NewUserDto {
                    UserName = user.UserName,
                    Email = user.Email,
                    Token = _tokenService.CreateToken(user, roles)
                }
            );
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try 
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var appUser = new User
                {
                    UserName = registerDto.UserName,
                    Email = registerDto.Email
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if(createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                    string userId = await _userManager.GetUserIdAsync(appUser);

                    var CreateClient = new Client 
                    {
                        UserId = userId
                    };
                    await _clientRepo.CreateAsync(CreateClient.ToClientDtoFromCreateDto());
                    if(roleResult.Succeeded) 
                    {
                        List<string> roles = new List<string>(await _userManager.GetRolesAsync(appUser));
                        return Ok(
                            new NewUserDto
                            {
                                UserName = appUser.UserName,
                                Email = appUser.Email,
                                Token = _tokenService.CreateToken(appUser, roles)
                            }
                        );
                    } else 
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            } catch(Exception ex) 
            {
                return StatusCode(500, ex);
            }
        }
    
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] string id, [FromHeader] string Authorization)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string jwt = Authorization.Remove(0, Authorization.IndexOf(' ') + 1);
            JwtSecurityToken decodedJwt = _tokenService.DecodeJwt(jwt);

            string IdUser = decodedJwt.Claims.First(claim => claim.Type == "unique_name").Value;
/* 
            Console.WriteLine("-----------------");
            string json = JsonSerializer.Serialize(IdUser);
            Console.WriteLine(json);
            Console.WriteLine("=================="); */
            

            var account = await _clientRepo.GetByIdAsync(id);

            if(account == null)
            {
                return NotFound();
            }

            return Ok(account);
        } 
    }
}
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using api.models;

namespace api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user, List<string> roles);
        JwtSecurityToken DecodeJwt(string? jwt);
    }
}
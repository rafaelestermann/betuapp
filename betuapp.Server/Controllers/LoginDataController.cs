using betuapp.Shared;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;

namespace betuapp.Server.Controllers
{
    [Route("api/[controller]")]
    public class LoginDataController : Controller
    {
        private readonly IConfiguration _configuration;

        public LoginDataController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost("[action]")]
        public IActionResult Login([FromBody] LoginDetails login)
        {
            if (login.Username == "admin" && login.Password == "SuperSecretPassword")
            {
                var claims = new[] { new Claim(ClaimTypes.Name, login.Username)        };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));
                var token = new JwtSecurityToken(
                    _configuration["JwtIssuer"],
                    _configuration["JwtIssuer"],
                    claims,
                    expires: expiry,
                    signingCredentials: creds
                );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            return BadRequest("Username and password are invalid.");
        }
    }
}

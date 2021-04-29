using MarketWatch.Application.DTOs.Requests;
using MarketWatch.Application.Interfaces.Services;
using MarketWatch.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;

        public AuthService(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<string> Register(RegisterRequestModel inputModel)
        {
            var user = new ApplicationUser
            {
                UserName = inputModel.Email,
                Email = inputModel.Email
            };

            var result = await this.userManager.CreateAsync(user, inputModel.Password);

            if (result.Succeeded)
            {
                string token = await GetToken(user);

                return token;
            }

            throw new Exception();
        }

        public async Task<string> Login(LoginRequestModel inputModel)
        {
            var user = await userManager.FindByNameAsync(inputModel.Email);

            if (user == null)
            {
                throw new Exception("Incorrect email!");
            }

            bool isPasswordCorrect = await userManager.CheckPasswordAsync(user, inputModel.Password);

            if (!isPasswordCorrect)
            {
                throw new Exception("Incorrect password!");
            }
            string token = await GetToken(user);

            return token;
        }

        private async Task<string> GetToken(ApplicationUser user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JWT").GetValue<string>("Secret")));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = await GetUserClaims(user);

            var tokenOptions = new JwtSecurityToken(
                issuer: configuration.GetSection("JWT").GetValue<string>("Issuer"),
                audience: configuration.GetSection("JWT").GetValue<string>("Audience"),
                claims: claims,
                expires: DateTime.Now.AddHours(12),
                signingCredentials: signingCredentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return token;
        }

        private async Task<List<Claim>> GetUserClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("id", user.Id.ToString()),
                new Claim("username", user.UserName)
            };

            return claims;
        }
    }
}

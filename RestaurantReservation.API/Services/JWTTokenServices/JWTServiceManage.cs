using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using RestaurantReservation.API.Entities;
using RestaurantReservation.API.Helpers;

namespace RestaurantReservation.API.Services
{
    public class JWTServiceManage : IJWTTokenServices
    {
        private readonly IConfiguration _configuration;
        private readonly DbContextData _dbContext;

        public JWTServiceManage(IConfiguration configuration, DbContextData dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public JWTTokens Authenticate(Users users)
        {
            if (!_dbContext.Users.Any(u => u.UserName == users.UserName && u.Password == users.Password))
            {
                return null;            
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["JWTToken:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, users.UserName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new JWTTokens { Token = tokenHandler.WriteToken(token) };
        }
    }
}

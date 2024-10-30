using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RestaurantReservation.API.Entities;
using RestaurantReservation.API.Helpers;

namespace RestaurantReservation.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;
        private readonly IJWTTokenServices _jwtTokenServices;

        public UsersController(IUsers users, IJWTTokenServices jwtTokenServices)
        {
            _users = users;
            _jwtTokenServices = jwtTokenServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_users.GetAll());
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(Users users)
        {
            var token = _jwtTokenServices.Authenticate(users);

            if (token == null)
            {
                return Unauthorized(new { Message = "Unauthorized" });
            }

            return Ok(token);
        }
    }
}

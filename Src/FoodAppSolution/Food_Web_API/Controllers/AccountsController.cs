using AuthenticationPlugin;
using Food_Web_API.Data;
using Food_Web_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private IConfiguration _configuration;
        private readonly AuthService _authService;

        public AccountsController(ApplicationDbContext dbContext, IConfiguration configuration, AuthService authService)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(User user)
        {
            var EmailAlreadyExists = _dbContext.Users.SingleOrDefault(
                x => x.Email == user.Email);
            if (EmailAlreadyExists != null)
            {
                return BadRequest("User's Email Already Exists!");
            }

            var userObj = new User
            {
                Email = user.Email,
                Name = user.Name,
                Password = SecurePasswordHasherHelper.Hash(user.Password),
                Role = "User"
            };

            _dbContext.Users.Add(userObj);
            await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}
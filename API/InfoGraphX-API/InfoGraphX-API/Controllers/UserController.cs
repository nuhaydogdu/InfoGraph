using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using InfoGraphX_API.VModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoGraphX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public UserController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User_VM user_VM)
        {
            var user = new User
            {
                AgeGroup = user_VM.AgeGroup,
                ViewedTitle = user_VM.ViewedTitle
            };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            List<User> users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }
    }
}

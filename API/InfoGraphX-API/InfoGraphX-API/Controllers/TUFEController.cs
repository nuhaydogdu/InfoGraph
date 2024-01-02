using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoGraphX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TUFEController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public TUFEController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllTUFEData()
        {
            try
            {
                List<Tufe> datas = await _dbContext.Tufe.ToListAsync();
                if (datas == null || datas.Count == 0)
                    return NotFound("No data found");

                return Ok(datas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
    }
}

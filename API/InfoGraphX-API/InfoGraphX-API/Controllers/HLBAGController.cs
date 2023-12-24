using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoGraphX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HLBAGController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public HLBAGController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetHLBAGData()
        {
            try
            {
                List<HappinessLevelByAgeGroup> hlbagData = await _dbContext.HappinessLevelByAgeGroups.ToListAsync();

                if (hlbagData == null || hlbagData.Count == 0)
                {
                    return NotFound("No data found");
                }

                return Ok(hlbagData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

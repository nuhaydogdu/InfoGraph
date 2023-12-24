using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoGraphX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FTVIController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public FTVIController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetFTVIData()
        {
            try
            {
                List<ForeignTradeValueIndice> ftviData = await _dbContext.ForeignTradeValueIndices.ToListAsync();

                if (ftviData == null || ftviData.Count == 0)
                {
                    return NotFound("No data found");
                }

                return Ok(ftviData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

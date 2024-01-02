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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllHLBAGData()
        {
            try
            {
                var result = _dbContext.HappinessLevelByAgeGroups
                    .Join(_dbContext.HappinesRates,
                          h => h.HappinesRatesId,
                          r => r.HappinesRatesId,
                          (h, r) => new { HappinessData = h, RatesData = r })
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetByYearHLBAGData([FromQuery] int year)
        {
            try
            {
                var result = _dbContext.HappinessLevelByAgeGroups
                    .Join(_dbContext.HappinesRates,
                          h => h.HappinesRatesId,
                          r => r.HappinesRatesId,
                          (h, r) => new { HappinessData = h, RatesData = r })
                    .Where(joinedData => joinedData.HappinessData.Year == year)
                    .Select(joinedData => new
                    {
                        HappinessDataId = joinedData.HappinessData.Id,
                        Year = joinedData.HappinessData.Year,
                        HappyRate = joinedData.RatesData.HappyRate,
                        MediumRate = joinedData.RatesData.MediumRate,
                        UpsetRate = joinedData.RatesData.UpsetRate,
                        AgeInterval = joinedData.RatesData.AgeInterval
                    })
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

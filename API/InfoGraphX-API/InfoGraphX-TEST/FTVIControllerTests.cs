using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoGraphX_API.Controllers;
using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

public class FTVIControllerTests
{
    [Fact]
    public async Task GetAllFTVIData_ReturnsListOfFTVIData()
    {
        // Arrange
        // Use an in-memory database for testing
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
            .Options;

        using (var dbContext = new MyDbContext(options))
        {
            var controller = new FTVIController(dbContext);

            var ftviDataList = new List<ForeignTradeValueIndice>
{
    new ForeignTradeValueIndice { Year = 2013, Month = "Ocak", ExportUniteValue = 117.01031F, ImportUniteValue = 125.26608F },
    // Add other test data as needed
};

            dbContext.ForeignTradeValueIndices.AddRange(ftviDataList);
            dbContext.SaveChanges();

            // Act
            var result = await controller.GetAllFTVIData() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            var resultList = Assert.IsType<List<ForeignTradeValueIndice>>(result.Value);
            Assert.NotEmpty(resultList);

            // Add more specific assertions based on your data
            Assert.Equal(2013, resultList[0].Year);
            Assert.Equal("Ocak", resultList[0].Month);
            Assert.Equal(117.01030731201172, resultList[0].ExportUniteValue);
            Assert.Equal(125.26608276367188, resultList[0].ImportUniteValue);
        }
    }


}

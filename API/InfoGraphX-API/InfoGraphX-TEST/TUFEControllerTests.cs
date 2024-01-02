using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InfoGraphX_API.Controllers;
using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

public class TUFEControllerTests
{
    [Fact]
    public async Task GetAllTUFEData_ReturnsListOfTUFEData()
    {
        // Arrange
        // Use an in-memory database for testing
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
            .Options;

        using (var dbContext = new MyDbContext(options))
        {
            var controller = new TUFEController(dbContext);

            var tufeDataList = new List<Tufe>
            {
                new Tufe { Year = 2014, Percentage = 24.45F, Group = "Gıda ve alkolsüz içecekler" },
                // Add other test data as needed
            };

            dbContext.Tufe.AddRange(tufeDataList);
            dbContext.SaveChanges();

            // Act
            var result = await controller.GetAllTUFEData() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            var resultList = Assert.IsType<List<Tufe>>(result.Value);
            Assert.NotEmpty(resultList);

            // Add more specific assertions based on your data
            Assert.Equal(2014, resultList[0].Year);
            Assert.Equal(24.45F, resultList[0].Percentage);
            Assert.Equal("Gıda ve alkolsüz içecekler", resultList[0].Group);
        }
    }
}

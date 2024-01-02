using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoGraphX_API.Controllers;
using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using InfoGraphX_API.VModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

public class UserControllerTests
{
    [Fact]
    public async Task GetUser_ReturnsListOfUsers()
    {
        // Arrange
        // Use an in-memory database for testing
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
            .Options;

        using (var dbContext = new MyDbContext(options))
        {
            var controller = new UserController(dbContext);

            var userList = new List<User>
            {
                new User { AgeGroup = "15-20", ViewedTitle = "Yaş Grubuna Göre Mutluluk Düzeyleri" },
                new User { AgeGroup = "55-60", ViewedTitle = "TÜFE" }
                // Add other test data as needed
            };

            dbContext.Users.AddRange(userList);
            dbContext.SaveChanges();

            // Act
            var result = await controller.GetUser() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            var resultList = Assert.IsType<List<User>>(result.Value);
            Assert.NotEmpty(resultList);

            // Add more specific assertions based on your data
            Assert.Equal("25-30", resultList[0].AgeGroup);
            Assert.Equal("Test Title", resultList[0].ViewedTitle);

            Assert.Equal("15-20", resultList[1].AgeGroup);
            Assert.Equal("Yaş Grubuna Göre Mutluluk Düzeyleri", resultList[1].ViewedTitle);
        }
    }

    [Fact]
    public async Task PostUser_AddsUserToDatabase()
    {
        // Arrange
        // Use an in-memory database for testing
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
            .Options;

        using (var dbContext = new MyDbContext(options))
        {
            var controller = new UserController(dbContext);

            var userVM = new User_VM { AgeGroup = "25-30", ViewedTitle = "Test Title" };

            // Act
            var result = await controller.PostUser(userVM) as OkResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            // Check if the user is added to the database
            var addedUser = await dbContext.Users.FirstOrDefaultAsync(u => u.AgeGroup == userVM.AgeGroup && u.ViewedTitle == userVM.ViewedTitle);
            Assert.NotNull(addedUser);
            Assert.Equal("25-30", addedUser.AgeGroup);
            Assert.Equal("Test Title", addedUser.ViewedTitle);
        }
    }
}

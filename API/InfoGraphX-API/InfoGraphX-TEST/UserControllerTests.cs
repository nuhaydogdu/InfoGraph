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

            var users = new List<User> { new User { AgeGroup = "18-25", ViewedTitle = "SampleTitle" } };
            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();

            // Act
            var result = await controller.GetUser() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            var resultList = Assert.IsType<List<User>>(result.Value);
            Assert.Single(resultList);
            Assert.Equal("18-25", resultList[0].AgeGroup);
            Assert.Equal("SampleTitle", resultList[0].ViewedTitle);
        }
    }

    [Fact]
    public async Task PostUser_ValidData_ReturnsOkResult()
    {
        // Arrange
        // Use an in-memory database for testing
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
            .Options;

        using (var dbContext = new MyDbContext(options))
        {
            var controller = new UserController(dbContext);

            var userVM = new User_VM { AgeGroup = "18-25", ViewedTitle = "SampleTitle" };

            // Act
            var result = await controller.PostUser(userVM) as OkResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }
    }
}

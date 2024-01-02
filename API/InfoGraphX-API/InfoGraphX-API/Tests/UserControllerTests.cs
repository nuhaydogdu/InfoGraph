//using InfoGraphX_API.Controllers;
//using InfoGraphX_API.Context;
//using InfoGraphX_API.Models;
//using InfoGraphX_API.VModel;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.EntityFrameworkCore.InMemory;
//using System.Threading.Tasks;

//namespace InfoGraphX_API.Tests
//{
//    [TestClass]
//    public class UserControllerTests
//    {
//        [TestMethod]
//        public async Task PostUser_ReturnsOkResult()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                var controller = new UserController(dbContext);

//                // Act
//                var userVm = new User_VM { AgeGroup = "TestAgeGroup", ViewedTitle = "TestViewedTitle" };
//                var result = await controller.PostUser(userVm) as OkResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(200, result.StatusCode);
//            }
//        }

//        [TestMethod]
//        public async Task GetUser_ReturnsOkResultWithUsers()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                dbContext.Users.Add(new User { AgeGroup = "TestAgeGroup", ViewedTitle = "TestViewedTitle" });
//                dbContext.SaveChanges();

//                var controller = new UserController(dbContext);

//                // Act
//                var result = await controller.GetUser() as OkObjectResult;
//                var users = result.Value as List<User>;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(200, result.StatusCode);
//                Assert.IsNotNull(users);
//                Assert.AreEqual(1, users.Count);

//                Console.WriteLine("Kod ÇAlıştııı----");
//            }
//        }
//    }
//}

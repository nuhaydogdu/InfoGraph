//using InfoGraphX_API.Controllers;
//using InfoGraphX_API.Context;
//using InfoGraphX_API.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace InfoGraphX_API.Tests
//{
//    [TestClass]
//    public class TUFEControllerTests
//    {
//        [TestMethod]
//        public async Task GetAllTUFEData_ReturnsOkResultWithData()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                dbContext.Tufe.Add(new Tufe { /* Add test data here */ });
//                dbContext.SaveChanges();

//                var controller = new TUFEController(dbContext);

//                // Act
//                var result = await controller.GetAllTUFEData() as OkObjectResult;
//                var datas = result.Value as List<Tufe>;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(200, result.StatusCode);
//                Assert.IsNotNull(datas);
//                Assert.IsTrue(datas.Count > 0);
//            }
//        }

//        [TestMethod]
//        public async Task GetAllTUFEData_ReturnsNotFoundWhenNoData()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                var controller = new TUFEController(dbContext);

//                // Act
//                var result = await controller.GetAllTUFEData() as ObjectResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(404, result.StatusCode);
//                Assert.AreEqual("No data found", result.Value);
//            }
//        }

//        [TestMethod]
//        public async Task GetAllTUFEData_ReturnsInternalServerErrorOnException()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                // Simulate an exception by not adding the necessary test data
//                var controller = new TUFEController(dbContext);

//                // Act
//                var result = await controller.GetAllTUFEData() as ObjectResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(500, result.StatusCode);
//                Assert.IsTrue(result.Value.ToString().StartsWith("Internal server error:"));
//            }
//        }
//    }
//}

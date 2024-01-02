//using InfoGraphX_API.Controllers;
//using InfoGraphX_API.Context;
//using InfoGraphX_API.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace InfoGraphX_API.Tests
//{
//    [TestClass]
//    public class FTVIControllerTests
//    {
//        [TestMethod]
//        public async Task GetAllFTVIData_ReturnsOkResultWithData()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                dbContext.ForeignTradeValueIndices.Add(new ForeignTradeValueIndice { /* Add test data here */ });
//                dbContext.SaveChanges();

//                var controller = new FTVIController(dbContext);

//                // Act
//                var result = await controller.GetAllFTVIData() as OkObjectResult;
//                var ftviData = result.Value as List<ForeignTradeValueIndice>;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(200, result.StatusCode);
//                Assert.IsNotNull(ftviData);
//                Assert.IsTrue(ftviData.Count > 0);
//            }
//        }

//        [TestMethod]
//        public async Task GetAllFTVIData_ReturnsNotFoundWhenNoData()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                var controller = new FTVIController(dbContext);

//                // Act
//                var result = await controller.GetAllFTVIData() as ObjectResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(404, result.StatusCode);
//                Assert.AreEqual("No data found", result.Value);
//            }
//        }

//        [TestMethod]
//        public async Task GetByYearFTVIData_ReturnsOkResultWithMatchingYear()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                var testYear = 2022;
//                dbContext.ForeignTradeValueIndices.Add(new ForeignTradeValueIndice { Year = testYear });
//                dbContext.SaveChanges();

//                var controller = new FTVIController(dbContext);

//                // Act
//                var result = await controller.GetByYearFTVIData(year: testYear) as OkObjectResult;
//                var ftviYearData = result.Value as List<ForeignTradeValueIndice>;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(200, result.StatusCode);
//                Assert.IsNotNull(ftviYearData);
//                Assert.IsTrue(ftviYearData.Count > 0);
//                Assert.IsTrue(ftviYearData.All(data => data.Year == testYear));
//            }
//        }

//        [TestMethod]
//        public async Task GetByYearFTVIData_ReturnsNotFoundWhenNoMatchingYear()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                var controller = new FTVIController(dbContext);

//                // Act
//                var result = await controller.GetByYearFTVIData(year: 2022) as ObjectResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(404, result.StatusCode);
//                Assert.AreEqual("No data found", result.Value);
//            }
//        }

//        [TestMethod]
//        public async Task GetByYearFTVIData_ReturnsInternalServerErrorOnException()
//        {
//            // Arrange
//            var dbContextOptions = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            using (var dbContext = new MyDbContext(dbContextOptions))
//            {
//                // Simulate an exception by not adding the necessary test data
//                var controller = new FTVIController(dbContext);

//                // Act
//                var result = await controller.GetByYearFTVIData(year: 2022) as ObjectResult;

//                // Assert
//                Assert.IsNotNull(result);
//                Assert.AreEqual(500, result.StatusCode);
//                Assert.AreEqual("Internal server error", result.Value);
//            }
//        }
//    }
//}

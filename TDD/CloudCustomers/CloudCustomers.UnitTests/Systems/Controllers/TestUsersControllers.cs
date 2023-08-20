using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixtures;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Systems.Controllers
{
    public class TestUsersControllers
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers())
                .ReturnsAsync(UsersFixture.GetTestUsers());

            //Act 
            var sut = new UsersController(mockUserService.Object);
            var result = await sut.Get();
            var objectResult = (OkObjectResult)result;
            objectResult.StatusCode.Should().Be(200);
            //Assert
        }

        [Fact]
        public async Task Get_OnSuccess_InvokesUserServiceExactlyOnce()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers()).ReturnsAsync(new List<User>());
            var sut = new UsersController(mockUserService.Object);
            //Act 

            var result = await sut.Get();

            mockUserService.Verify(service=>service.GetAllUsers(),Times.Once());
            //Assert
        }

        [Fact]
        public async Task Get_OnSuccess_ReturnsListOfUsers()
        {

            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers())
                .ReturnsAsync(UsersFixture.GetTestUsers());
            //Act
            var sut = new UsersController(mockUserService.Object);
            var result = await sut.Get();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult) result;
            objectResult.Value.Should().BeOfType<List<User>>();


        }

        [Fact]
        public async Task Get_OnNoUserFound_Returns404()
        {

            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());
            //Act
            var sut = new UsersController(mockUserService.Object);
            var result = await sut.Get();
            //Assert
            result.Should().BeOfType<NotFoundResult>();
            var objectResult = (NotFoundResult) result;
            objectResult.StatusCode.Should().Be(404);

        }
    }
}

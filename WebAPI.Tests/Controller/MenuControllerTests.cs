using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeItEasy;
using api.Interfaces;
using api.Dtos.Menu;
using api.Controllers;
using api.Data;
using FluentAssertions;
using api.Helpers.QueryObjects;
using api.Repository;
using Microsoft.AspNetCore.Mvc;
using api.models;

namespace WebAPI.Tests.Controller
{
     public class MenuControllerTests
    {
        private readonly IMenuRepository _menuRepo;
        private readonly MenuController _controller;

        public MenuControllerTests()
        {
            _menuRepo = A.Fake<IMenuRepository>(); 
            _controller = new MenuController(null, _menuRepo);
        }

        [Fact]
        public async Task GetAll_Returns_AllMenuItems()
        {
            var query = new MenuQueryObject();
            var fakeMenuItems = new List<Menu>(); 

            A.CallTo(() =>  _menuRepo.GetAllAsync(query)).Returns(Task.FromResult(fakeMenuItems)); 

            var result = await _controller.GetAll(query) as ObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Should().BeOfType(typeof(OkObjectResult));
        }
    } 
}
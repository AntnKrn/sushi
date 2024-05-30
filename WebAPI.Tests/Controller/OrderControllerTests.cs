using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.models;
using Xunit;
using api.Controllers;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using api.models;
using api.Dtos.Orders;

namespace WebAPI.Tests.Controller
{
    public class OrderControllerTests
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IOrderItemRepository _orderItemRepo;
        private readonly IMenuRepository _menuRepo;
        private readonly OrderController _controller;

        public OrderControllerTests()
        {
            _orderRepo = A.Fake<IOrderRepository>(); 
            _orderItemRepo = A.Fake<IOrderItemRepository>();
            _menuRepo = A.Fake<IMenuRepository>();
            _controller = new OrderController(_orderRepo, _orderItemRepo);
        }
        [Fact]
        public async Task GetAll_Returns_ReturnAllOrders()
        {
            var fakeOreder = new List<Order>(); 

            A.CallTo(() =>  _orderRepo.GetAllAsync()).Returns(Task.FromResult(fakeOreder)); 

            var result = await _controller.GetAll() as ObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Should().BeOfType(typeof(OkObjectResult));
        }
        
    }
}
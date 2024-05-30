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
    public class WorkerControllerTests
    {
        private readonly IWorkerRepository _workerRepo;
        private readonly WorkerController _controller;

        public WorkerControllerTests()
        {
            _workerRepo = A.Fake<IWorkerRepository>(); 
            _controller = new WorkerController(null, _workerRepo);
        }
        [Fact]
        public async Task GetAll_Returns_ReturnAllWorkers()
        {
            var fakeWorker = new List<Worker>(); 

            A.CallTo(() =>  _workerRepo.GetAllAsync()).Returns(Task.FromResult(fakeWorker)); 

            var result = await _controller.GetAll() as ObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Should().BeOfType(typeof(OkObjectResult));
        }
        
    }
}
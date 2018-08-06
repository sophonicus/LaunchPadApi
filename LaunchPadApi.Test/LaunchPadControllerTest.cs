using LaunchPadApi.Controllers;
using LaunchPadApi.Services;
using LaunchPadApi.Test.TestHelpers;
using LaunchPadApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LaunchPadApi.Test
{
    public class LaunchPadControllerTest
    {
        private LaunchPadController _launchPadController;
        private ISpaceXApiCaller _spaceXCaller;
        private XUnitLogger<LaunchPadController> _logger;

        public LaunchPadControllerTest(ITestOutputHelper output)
        {
            _spaceXCaller = new SpaceXApiCallerFake();
            _logger = new XUnitLogger<LaunchPadController>(output);
            _launchPadController = new LaunchPadController(_logger, _spaceXCaller);
        }

        [Fact]
        public void Get_ReturnsOkResult()
        {
            // Act
            var okResult = _launchPadController.Get();

            // Assert
            Assert.IsType<List<LaunchPadViewModel>>(okResult);
        }

        [Fact]
        public void Get_ReturnsAllItems()
        {
            // Act
            var okResult = _launchPadController.Get() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<LaunchPadViewModel>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}

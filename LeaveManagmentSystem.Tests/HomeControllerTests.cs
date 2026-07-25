using LeaveManagmentSystem_Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace LeaveManagmentSystem.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void About_Returns_ViewResult()
        {
            // Arrange
            var logger = new NullLogger<HomeController>();
            var controller = new HomeController(logger);

            // Act
            IActionResult result = controller.About();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}

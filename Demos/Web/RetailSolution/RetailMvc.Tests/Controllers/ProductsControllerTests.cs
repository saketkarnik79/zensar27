using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using RetailMvc.Controllers;
using RetailMvc.Models;
using RetailMvc.Services;
using Xunit;

namespace RetailMvc.Tests.Controllers;

public class ProductsControllerTests
{
    private readonly Mock<IProductService> _mockService;

    private readonly ProductsController _controller;

    public ProductsControllerTests()
    {
        _mockService = new Mock<IProductService>();

        _controller = new ProductsController(
            _mockService.Object,
            NullLogger<ProductsController>.Instance);
    }

    [Fact]
    public void Index_ReturnsViewResult()
    {
        // Arrange
        _mockService.Setup(s => s.GetAll())
            .Returns(new List<Product>());

        // Act
        var result = _controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void Index_ReturnsProductList()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000
            },
            new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 25000
            }
        };

        _mockService.Setup(s => s.GetAll())
            .Returns(products);

        // Act
        var result = _controller.Index();

        // Assert
        var viewResult =
            Assert.IsType<ViewResult>(result);

        var model =
            Assert.IsAssignableFrom<IEnumerable<Product>>(
                viewResult.Model);

        Assert.Equal(2, model.Count());

        Assert.Contains(
            model,
            p => p.Name == "Laptop");
    }

    [Fact]
    public void Details_ReturnsProduct_WhenProductExists()
    {
        // Arrange
        var product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 50000
        };

        _mockService.Setup(s => s.GetById(1))
            .Returns(product);

        // Act
        var result = _controller.Details(1);

        // Assert
        var viewResult =
            Assert.IsType<ViewResult>(result);

        var model =
            Assert.IsType<Product>(viewResult.Model);

        Assert.Equal("Laptop", model.Name);

        Assert.Equal(50000m, model.Price);
    }

    [Fact]
    public void Details_ReturnsNotFound_WhenProductDoesNotExist()
    {
        // Arrange
        _mockService.Setup(s => s.GetById(999))
            .Returns((Product?)null);

        // Act
        var result = _controller.Details(999);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
public void Create_ReturnsView_WhenModelIsInvalid()
    {
        // Arrange
        var product = new Product
        {
            Name = "",
            Price = 0
        };

        _controller.ModelState.AddModelError(
            "Name", "Product name is required");

        // Act
        var result = _controller.Create(product);

        // Assert
        var viewResult =
            Assert.IsType<ViewResult>(result);

        Assert.Same(product, viewResult.Model);

        _mockService.Verify(
            s => s.Add(It.IsAny<Product>()),
            Times.Never());
    }

    [Fact]
    public void Create_RedirectsToIndex_WhenModelIsValid()
    {
        // Arrange
        var product = new Product
        {
            Name = "Monitor",
            Price = 12000
        };

        // Act
        var result = _controller.Create(product);

        // Assert
        var redirectResult =
            Assert.IsType<RedirectToActionResult>(result);

        Assert.Equal(
            "Index",
            redirectResult.ActionName);

        _mockService.Verify(
            s => s.Add(product),
            Times.Once());
    }

    [Fact]
    public void GetProducts_ReturnsJsonResult()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000
            }
        };

        _mockService.Setup(s => s.GetAll())
            .Returns(products);

        // Act
        var result = _controller.GetProducts();

        // Assert
        var jsonResult =
            Assert.IsType<JsonResult>(result);

        var model =
            Assert.IsAssignableFrom<IEnumerable<Product>>(
                jsonResult.Value);

        Assert.Single(model);
    }
}
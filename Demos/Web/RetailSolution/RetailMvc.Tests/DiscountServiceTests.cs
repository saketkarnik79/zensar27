using RetailMvc.Services;
using Xunit;

namespace RetailMvc.Tests.Services;

public class DiscountServiceTests
{
    [Fact]
    public void CalculateDiscount_ReturnsZero_ForSmallAmount()
    {
        // Arrange
        var service = new DiscountService();

        // Act
        decimal result =
            service.CalculateDiscount(3000);

        // Assert
        Assert.Equal(0m, result);
    }

    [Fact]
    public void CalculateDiscount_ReturnsTenPercent()
    {
        // Arrange
        var service = new DiscountService();

        // Act
        decimal result =
            service.CalculateDiscount(8000);

        // Assert
        Assert.Equal(800m, result);
    }

    [Fact]
    public void CalculateDiscount_ReturnsTwentyPercent()
    {
        // Arrange
        var service = new DiscountService();

        // Act
        decimal result =
            service.CalculateDiscount(15000);

        // Assert
        Assert.Equal(3000m, result);
    }

    [Theory]
    [InlineData(3000, 0)]
    [InlineData(4999, 0)]
    [InlineData(5000, 500)]
    [InlineData(8000, 800)]
    [InlineData(10000, 2000)]
    [InlineData(15000, 3000)]
    public void CalculateDiscount_ReturnsExpectedDiscount(
        int amount,
        int expectedDiscount)
    {
        // Arrange
        var service = new DiscountService();

        // Act
        decimal result =
            service.CalculateDiscount(amount);

        // Assert
        Assert.Equal((decimal)expectedDiscount, result);
    }

    [Fact]
    public void CalculateFinalAmount_ReturnsCorrectAmount()
    {
        // Arrange
        var service = new DiscountService();

        // Act
        decimal result =
            service.CalculateFinalAmount(10000);

        // Assert
        Assert.Equal(8000m, result);
    }

    [Fact]
    public void CalculateDiscount_ThrowsException_ForNegativeAmount()
    {
        // Arrange
        var service = new DiscountService();

        // Act and Assert
        var exception = Assert.Throws<ArgumentException>(
            () => service.CalculateDiscount(-1000));

        Assert.Equal(
            "Amount cannot be negative",
            exception.Message);
    }
}
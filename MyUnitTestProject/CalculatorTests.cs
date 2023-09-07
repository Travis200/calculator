using Xunit;
using MyUnitTestProject;

public class CalculatorTests
{
    [Fact]
    public void Add_PositiveNumbers_ReturnsExpectedResult()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 3;
        int b = 5;
        int expectedResult = 8;

        // Act
        int actualResult = calculator.Add(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Subtract_PositiveNumbers_ReturnsExpectedResult() {

        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;
        int expectedResult = 2;

        // Act
        int actualResult = calculator.Subtract(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);

    }

    [Fact]
    public void Multiply_PositiveNumbers_ReturnsExpectedResult() {

        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;
        int expectedResult = 15;

        // Act
        int actualResult = calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);

    }

    [Fact]
    public void Divide_PositiveNumbers_ReturnsExpectedResult() {

        // Arrange
        var calculator = new Calculator();
        int a = 8;
        int b = 2;
        int expectedResult = 4;

        // Act
        int actualResult = calculator.Divide(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);

    }

}
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(8, calc.Add(5, 3));
    }

    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(2, calc.Subtract(5, 3));
    }

    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(15, calc.Multiply(5, 3));
    }

    [Fact]
    public void Divide_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(5.0 / 3.0, calc.Divide(5, 3));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
    }
}




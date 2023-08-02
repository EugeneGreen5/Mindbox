using Mindbox.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Tests.Task;
public class TestCircle
{
    [Theory]
    [InlineData(2.5, 19.625)]
    [InlineData(3.9, 47.7594)]
    [InlineData(149, 69711.14)]
    public void TestCorrectInput(double radius, double expected)
    {
        var circle = new Circle(radius);

        var result = circle.CalculateArea();

        Assert.Equal(expected, result);
    }

    
    [Theory]
    [InlineData(-4, "Неверные входные данные")]
    [InlineData(0, "Неверные входные данные")]
    public void TestUncorrectInput(double radius, string expected)
    {
        var exception = Assert.Throws<Exception>(() => new Circle(radius));

        Assert.Equal(expected, exception.Message);
    }
}

using Mindbox.Task;
using Mindbox.Task.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindbox.Tests.Task;
public class TestTriangle
{
    [Theory]
    [InlineData(2, 1, 1.8, 0.898)]
    [InlineData(4, 7, 10, 10.92875)]
    [InlineData(10, 15, 20, 72.61844)]
    public void TestCorrectInput(double firstSide, double secondSide, double thirdSide, double expected)
    {
        var triangle = new Triangle(firstSide,secondSide, thirdSide);

        var result = triangle.CalculateArea();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(12, 35, 37, 210)]
    public void TestRightTriangleInput(double firstSide, double secondSide, double thirdSide, double expected)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        var result = triangle.CalculateArea();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-1, 3, 2, "Неверные входные данные")]
    [InlineData(3 , 0, 2, "Неверные входные данные")]
    [InlineData(4 , 7, 12, "Неверные входные данные")]
    public void TestUncorrectInput(double firstSide, double secondSide, double thirdSide, string expected)
    {
        var exception = Assert.Throws<Exception>(() => new Triangle(firstSide,secondSide,thirdSide));

        Assert.Equal(expected, exception.Message);
    }
}

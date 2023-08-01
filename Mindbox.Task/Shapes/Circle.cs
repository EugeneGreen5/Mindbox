namespace Mindbox.Task;

internal class Circle : FigureBase
{
    private readonly double _PI = Math.Round(Math.PI, 2);
    private double _radius;

    public Circle(double radius)
    {
        if (!isValidateInput()) throw new Exception("Неверные входные данные")

        _radius = radius;
    }

    public override double CalculateArea() =>
        Math.Pow(_radius, 2) * _PI;

    public override bool isValidateInput()
        => (_radius <= 0) ? false : true;
}

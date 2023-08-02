namespace Mindbox.Task;

/// <summary>
/// Класс, представляющий сущность круг, наследованный от базового класса
/// </summary>
public class Circle : FigureBase
{
    /// <summary>
    /// Число PI, округленное до 2-ух знаком после запятой
    /// </summary>
    private readonly double _PI = Math.Round(Math.PI, 2);
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;

        if (!isValidateInput()) throw new Exception("Неверные входные данные");
    }

    /// <summary>
    /// Метод, высчитывающий площать круга по формуле: S = PI * (radius ^ 2)
    /// </summary>
    /// <returns>Площадь круга</returns>
    public override double CalculateArea() =>
        Math.Pow(_radius, 2) * _PI;

    /// <summary>
    /// Метод, проверяющий существование круга с исходными данными.
    /// </summary>
    /// <returns>
    /// Значение true, если круг существует.
    /// Значение false, если круга не существует.
    /// </returns>
    public override bool isValidateInput()
        => (_radius <= 0) ? false : true;
}

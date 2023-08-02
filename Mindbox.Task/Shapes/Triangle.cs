namespace Mindbox.Task.Shapes;
/// <summary>
/// Класс, представляющий сущность треугольник, наследованный от базового класса.
/// </summary>
public class Triangle : FigureBase
{
    /// <summary>
    /// Отсортированный список сторон треугольника
    /// </summary>
    private List<double> _sides = new List<double>(3);

    public bool _isRight { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {

        #region Добавление элементов в список и сортировка списка
        AddElementInList(firstSide,secondSide,thirdSide);
        _sides.Sort();
        #endregion

        if (!isValidateInput()) throw new Exception("Неверные входные данные");

        _isRight = isRightTriangle();
    }

    /// <summary>
    /// Метод, высчитывающий площать треугольника по двум сценариям:
    /// 1) Если треугольник - прямоугольный - считывается по формуле S = 1/2 * a * b;
    /// 2) Если треугольник - обычный - считается по 1-ой формуле Герона;
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public override double CalculateArea()
    {
        if (_isRight) return _sides[0] * _sides[1] / 2;

        #region Реализация 1-ой формулы Герона
        double semiperimeter = 0.5 * (_sides[0] + _sides[1] + _sides[2]);
        return Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - _sides[0]) * (semiperimeter - _sides[1]) * (semiperimeter - _sides[2])),5);
        #endregion
    }

    /// <summary>
    /// Метод, проверяющий существование треугольника с исходными данными.
    /// </summary>
    /// <returns>
    /// Значение true, если треугольник существует.
    /// Значение false, если треугольника не существует.
    /// </returns>
    public override bool isValidateInput()
    {
        if (_sides[2] >= _sides[0] + _sides[1]) return false;

        return true;
    }

    /// <summary>
    /// Метод, проверяющий треугольник на прямоугольность.
    /// </summary>
    /// <returns>
    /// Значение true, если треугольник прямоугольный.
    /// Значение false, если треугольник не прямоугольный.
    /// </returns>
    private bool isRightTriangle()
    {
        if (Math.Pow(_sides[2], 2) == Math.Pow(_sides[1], 2) + Math.Pow(_sides[0], 2)) return true;

        return false;
    }

    /// <summary>
    /// Вспомогательный метод, добавляющий входные значения в список сторон треугольнка
    /// </summary>
    /// <param name="firstSide">Первая сторона</param>
    /// <param name="secondSide">Вторая сторона</param>
    /// <param name="thirdSide">Третья сторона</param>
    private void AddElementInList(double firstSide, double secondSide, double thirdSide)
    {
        _sides.Add(firstSide);
        _sides.Add(secondSide);
        _sides.Add(thirdSide);
    }
}

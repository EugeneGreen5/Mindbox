namespace Mindbox.Task.Shapes;

public class Triangle : FigureBase
{
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



    public override double CalculateArea()
    {
        if (_isRight) return _sides[0] * _sides[1] / 2;

        #region Реализация 1-ой формулы Герона
        double semiperimeter = 0.5 * (_sides[0] + _sides[1] + _sides[2]);
        return Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - _sides[0]) * (semiperimeter - _sides[1]) * (semiperimeter - _sides[2])),5);
        #endregion
    }

    public override bool isValidateInput()
    {
        if (_sides[2] >= _sides[0] + _sides[1]) return false;

        return true;
    }

    private bool isRightTriangle()
    {
        if (Math.Pow(_sides[2], 2) == Math.Pow(_sides[1], 2) + Math.Pow(_sides[0], 2)) return true;

        return false;
    }

    private void AddElementInList(double firstSide, double secondSide, double thirdSide)
    {
        _sides.Add(firstSide);
        _sides.Add(secondSide);
        _sides.Add(thirdSide);
    }
}

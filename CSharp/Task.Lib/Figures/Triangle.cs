namespace Task.Lib.Figures;

public sealed class Triangle : Figure
{
    private double Ab { get; }
    private double Bc { get; }
    private double Ac { get; }

    public Triangle(string name, double ab, double bc, double ac) : base(name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Некорректное имя фигуры!");
        
        if (ab <= 0 || bc <= 0 || ac <= 0)
            throw new ArgumentException("AB или BC ли AC <= 0!");

        if (ab > bc + ac || bc > ab + ac || ac > ab + bc)
            throw new ArgumentException("Какая-то сторона больше, чем сумма двух других сторон");

        Ab = ab;
        Bc = bc;
        Ac = ac;
    }
    
    public override double GetSquare()
    {
        var perimeter = (Ab + Bc + Ac) / 2;

        return Math.Round(Math.Sqrt(perimeter * (perimeter - Ab) * (perimeter - Bc) * (perimeter - Ac)), 1);
    }
    
    /// <summary>
    /// Это прямоугольный треугольник или нет
    /// </summary>
    public bool IsRectange() 
        => Ab * Ab + Bc * Bc == Ac * Ac || Ab * Ab + Ac * Ac == Bc * Bc || Ac * Ac + Bc * Bc == Ab * Ab;
}
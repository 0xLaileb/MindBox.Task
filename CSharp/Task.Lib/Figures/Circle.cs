namespace Task.Lib.Figures;

public record Circle : Figure
{
    private double Radius { get; }

    public Circle(string name, double radius) : base(name)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус <= 0!");
        
        Radius = radius;
    }

    public override double GetSquare() 
        => Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
}
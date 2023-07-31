namespace Task.Lib;

public abstract class Figure
{
    public string Name { get; }

    protected Figure(string name) 
        => Name = name;

    /// <summary>
    /// Получить площадь
    /// </summary>
    public abstract double GetSquare();
}
namespace Task.Lib;

public abstract record Figure(string Name)
{
    public string Name { get; } = Name;

    /// <summary>
    /// Получить площадь
    /// </summary>
    public abstract double GetSquare();
}
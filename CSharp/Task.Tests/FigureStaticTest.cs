using Task.Lib;

namespace Task.Tests;

public class FigureStaticTest
{
    [TestCase(10, 314.2d)]
    [TestCase(5, 78.5d)]
    [TestCase(20494, 1319481594.0d)]
    [TestCase(2, 12.6d)]
    public void FigureStatic_Circle_GetSquare_IsOk(double radius, double result)
    {
        var circle = new Circle("Круг", radius);
        
        var resultSquare = FigureStatic.GetSquare(circle);
        
        Assert.That(resultSquare, Is.EqualTo(result));
    }
    
    [TestCase(10, 10, 15, 49.6d)]
    [TestCase(11, 11, 16, 60.399999999999999d)]
    [TestCase(3, 4, 5, 6.0d)]
    public void FigureStatic_Triangle_GetSquare_IsOk(double ab, double bc, double ac, double result)
    {
        var triangle = new Triangle("Треуольник", ab, bc, ac);
        
        var resultSquare =  FigureStatic.GetSquare(triangle);

        Assert.That(resultSquare, Is.EqualTo(result));
    }
}
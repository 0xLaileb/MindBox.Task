namespace Task.Tests;

public class CircleTest
{
    [TestCase(10, 314.2d)]
    [TestCase(5, 78.5d)]
    [TestCase(20494, 1319481594.0d)]
    [TestCase(2, 12.6d)]
    public void Circle_GetSquare_IsOk(double radius, double result)
    {
        var circle = new Circle("Круг", radius);
        
        var resultSquare = circle.GetSquare();
        
        Assert.That(resultSquare, Is.EqualTo(result));
    }
    
    [Test]
    public void Circle_GetSquare_IsInvalidRadius()
    {
        const int radius = -1;

        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle("Круг", radius);

            circle.GetSquare();
        });
    }
}
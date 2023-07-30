namespace Task.Tests;

public class TriangleTest
{
    [TestCase(10, 10, 15, 49.6d)]
    [TestCase(11, 11, 16, 60.399999999999999d)]
    [TestCase(3, 4, 5, 6.0d)]
    public void Triangle_GetSquare_IsOk(double ab, double bc, double ac, double result)
    {
        var triangle = new Triangle("Треуольник", ab, bc, ac);
        
        var resultSquare = triangle.GetSquare();

        Assert.That(resultSquare, Is.EqualTo(result));
    }
    
    [TestCase(0, 10, 15)]
    [TestCase(10, 0, 15)]
    [TestCase(10, 10, 0)]
    [TestCase(-1, 10, 15)]
    [TestCase(10, -1, 15)]
    [TestCase(10, 10, -1)]
    [TestCase(0, 0, 0)]
    [TestCase(-1, -1, -1)]
    [TestCase(0, 0, 15)]
    [TestCase(10, 0, 0)]
    [TestCase(2, 33, 20)]
    public void Triangle_GetSquare_IsInvalid_Args(double ab, double bc, double ac)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle("Треуольник", ab, bc, ac);

            triangle.GetSquare();
        });
    }
    
    [TestCase(4, 5, 3, true)]
    [TestCase(3, 5, 4, true)]
    [TestCase(1, 5, 4, false)]
    public void Triangle_GetSquare_IsRectange(double ab, double bc, double ac, bool result)
    {
        var triangle = new Triangle("Треуольник", ab, bc, ac);
        
        var resultSquare = triangle.IsRectange();

        Assert.That(resultSquare, Is.EqualTo(result));
    }
}
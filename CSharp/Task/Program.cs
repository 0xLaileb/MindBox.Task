using Task.Lib;
using Task.Lib.Figures;
using static System.Console;

// #1 - получение площади круга с определенным радиусом
const int radius = 10;
var circle = new Circle("Круг", radius);
var resultSquare = circle.GetSquare();

WriteLine($"Площадь круга с радиусом {radius} = {resultSquare}");

// #2 - получение площади треугольника с определенными сторонами
const double ab = 10;
const double bc = 10;
const double ac = 15;
var triangle = new Triangle("Треуольник", ab, bc, ac);
resultSquare = triangle.GetSquare();

WriteLine($"Площадь треугольника со сторонами ab={ab};bc={bc};ac={ac} = {resultSquare}");

// #3 - получение вывода о том, что треугольник прямоугольный
WriteLine($"Это прямоугольный треугольник? Ответ = {new Triangle("Прямоугольный треугольник", 4, 5, 3).IsRectange()}");

// #4 - вычисление площади фигуры без знания типа фигуры в compile-time (static)
WriteLine($"[compile-time] Площадь круга с радиусом {radius} = {FigureStatic.GetSquare(circle)}");
WriteLine($"[compile-time] Площадь треугольника со сторонами ab={ab};bc={bc};ac={ac} = {FigureStatic.GetSquare(triangle)}");
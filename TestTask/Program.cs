using TestTask.Interface;

double radius = 5;
IShape circle = ShapeFactory.CreateCircle(radius);
double circleArea = circle.CalculateArea();
Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");

// Пример: Вычисление площади треугольника
double sideA = 3;
double sideB = 4;
double sideC = 5;
IShape triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
double triangleArea = triangle.CalculateArea();
Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC}: {triangleArea}");

// Проверка, является ли треугольник прямоугольным
Triangle specificTriangle = triangle as Triangle;
if (specificTriangle != null)
{
    bool isRightTriangle = specificTriangle.IsRightTriangle();
    Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} прямоугольный: {isRightTriangle}");
}
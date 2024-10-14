using TestTask.Interface;
using TestTask.Service;

namespace GeometryTests;

[TestFixture]
public class Tests
{
    [Test]
    public void CircleArea_ShouldBeCorrect()
    {
        // Arrange
        double radius = 5;
        IShape circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area);
    }

    [Test]
    public void TriangleArea_ShouldBeCorrect()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        IShape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, area);
    }

    [Test]
    public void Triangle_ShouldBeRightAngled()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.IsTrue(isRight);
    }
}
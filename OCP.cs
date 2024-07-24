namespace OCP;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public sealed class Square : Shape
{
    double side;

    public override double CalculateArea()
    {
        return side*side;
    }
}

public sealed class Circle : Shape
{
    double radius;
    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
}

abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }


    public abstract double GetArea();

    public virtual void DisplauColor()
    {
        Console.WriteLine($"shape color: {Color}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(string color, double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void DisplauColor()
    {
        Console.WriteLine($"Circle color: {Color}");
    }

}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

public class ExampleAbstract
{
    public static void Run()
    {
        //Shape shape  = new Shape("Red"); // Error: Cannot create an instance of the abstract class 'Shape'
        Circle circle = new Circle("Blue", 5);
        Rectangle rectangle = new Rectangle("Green", 10, 7);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        circle.DisplauColor();
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        rectangle.DisplauColor();
    }
}
}
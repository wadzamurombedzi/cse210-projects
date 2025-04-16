using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new (4, "Red");
        Rectangle rectangle = new (8, 5, "Green");
        Circle circle = new (7, "Orange-Red");

        List<Shape> _shapeAreas = new()
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in _shapeAreas)
        {
            Console.WriteLine($"{shape.GetColor()} - {Math.Round(shape.GetArea(), 2)}");
        }
        Console.WriteLine("");

        Console.WriteLine($"The area of the {square.GetColor()} Square is: {square.GetArea()}");
        Console.WriteLine($"The area of the {rectangle.GetColor()} Rectangle is: {rectangle.GetArea()}");
        Console.WriteLine($"The area of the {circle.GetColor()} Circle is: {Math.Round(circle.GetArea(), 2)}");
    }
}
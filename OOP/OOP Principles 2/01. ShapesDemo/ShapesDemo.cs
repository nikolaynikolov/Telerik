using Shapes;
using System;

class ShapesDemo
{

    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
        new Triangle(15, 16),
        new Rectangle(17, 18),
        new Circle(9),
        };
        double[] shapeAreas = new double[shapes.Length];
        int index = 0;
        foreach (Shape shape in shapes)
        {
            shapeAreas[index] = shape.CalculateArea();
            Console.WriteLine("[{0}]: area = {1:F4} square meters!", shape.GetType(), shapeAreas[index]);
            index++;
        }
    }
}
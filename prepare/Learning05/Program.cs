using System;

class Program
{
   static void Main(string[] args)
   {
      List<Shape> shapes = new List<Shape>();

      Square square = new Square("red", 5);
      shapes.Add(square);

      Rectangle rect = new Rectangle("blue", 8, 4);
      shapes.Add(rect);

      Circle circle = new Circle("purple", 5);
      shapes.Add(circle);


      foreach (Shape shape in shapes)
      {
         Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
      }


   }
}
using System;
using System.Collections.Generic;
namespace Practics
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);
            foreach(Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
            
        }
        static void Do(object obj)
        {
            bool IsPointRef = obj is PointRef;
            if (IsPointRef)
            {
                PointRef pt = (PointRef)obj;
                
            }
            PointRef pr1 = obj as PointRef;
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a = {a}, b = {b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swapped a = {a}, b = {b}");

        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}

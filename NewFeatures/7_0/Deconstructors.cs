using System;

namespace NewFeatures._7_0
{
    public class Deconstructors
    {
        public static void Run()
        {
            var myPoint = new Point();
            
            //multi variable declaration
            var (x, y) = myPoint;
            
            // if we don't care about one variable, we can ignore it using "_"
            var (a, _) = myPoint;
            
            Console.WriteLine($"{x}");
        }
    }

    public class Point
    {
        public int X, Y;

        public void Deconstruct(out int x, out int y) // how we can write deconstructor
        {
            x = X;
            y = Y;
        }
    }
}
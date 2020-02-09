using System;

namespace NewFeatures._7_2
{
    //this structure can be passed by reference - not a full copy of entire memory
    struct Point // some value type
    {
        public double X, Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    
    public class InParameters
    {
        static double MeasureDistance(in Point p1, in Point p2) // this structure is going to be passed by reference, but not by value
        {                                                // it is passed as memory address
                                                        // in keyword causes, that structure is readonly
            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;

            return Math.Sqrt(dx * dx + dy * dy); //square root of the squares
        }

        public static void Run()
        {
            var p1 = new Point(1,1);
            var p2 = new Point(4,5);

            var distance = MeasureDistance(p1, p2); //this is how we get reference semantics for value types
            Console.WriteLine($"Distance between {p1} and {p2} is {distance}"); // prints 5
        }
    }
}
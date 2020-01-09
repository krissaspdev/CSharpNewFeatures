using System;

namespace NewFeatures._7_0
{
    public class TupleDemo
    {
        //old fashion Tuple
        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        //new Tuple (in older version one needs add nuget package)
        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }


        public static void Run()
        {
            var sp = SumAndProduct(2, 3);
            Console.WriteLine($"sum: {sp.Item1}, product {sp.Item2}");
            
            //new Tuple
            var sp2 = NewSumAndProduct(2, 3);
            // in new Tuple you gets code completion
            Console.WriteLine($"sum: {sp2.sum}, product {sp2.product}");

            //new Tuple gives 2 varieties of syntax
            //1
            (double ss, double pp) = NewSumAndProduct(2, 3);
            //2
            var (sum, product) = NewSumAndProduct(2, 3);
            
            //we can declare variables separately
            double s, p;
            (s, p) = NewSumAndProduct(2, 3);

            // making a Tuple in place
            var me = (name: "Kris", age: 123);
            Console.WriteLine(me);
            Console.WriteLine($"My name is {me.name} and I'm {me.age} years old.");
            
            //it is possible to define q func with tuples
            var spn = new Func<double, double, (double sum, double product)>((a, b) => (a + b, a * b));
            var result = spn(1, 2);
            Console.WriteLine(result.product);

        }
    }
}
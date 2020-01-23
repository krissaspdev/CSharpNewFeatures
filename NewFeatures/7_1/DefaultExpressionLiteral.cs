using System;
using System.Collections.Generic;

namespace NewFeatures._7_1
{
    public class DefaultExpressionLiteral
    {
        public DateTime GetTimestamps(List<int> items = default) // we can define default in parameters
        {
            return default; 
        }

        public static void Run()
        {
            int a = default; 
            int b = default(int); // we can specify the type, but it's redundant

            int? d = default;
            Console.WriteLine(d == null);
            
            var e = new[] { default, 33, default}; // system is able to determine thar array is int

            string s = default; // setting reference type

            var x = a > 0 ? default : 1.5; // default double

        }
    }
}
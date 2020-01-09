using System;
using System.Data;

namespace NewFeatures._7_0
{
    public class OutVariable
    {
        public static void Run()
        {
            if (DateTime.TryParse("02/02/2016", out var dt))
            {
                Console.WriteLine(dt);
            }
            
            // dt is visible outside the scope
            Console.WriteLine(dt.Day);

            int.TryParse("abc", out var i);
            // if parsing do not succeed, you will get default value for type
            Console.WriteLine(i);
        }
    }
}
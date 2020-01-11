using System;

namespace NewFeatures._7_0
{
    public class ReferenceDemo
    {
        public static void Run()
        {
            int[] numbers = {1, 2, 3};
            ref int refToSecond = ref numbers[1];

            // getting value -> copy to variable
            var valueOfSecond = refToSecond;
            
            // modify through a reference
            refToSecond = 123;
            // second value will be 123
            Console.WriteLine(string.Join(", ", numbers));
            
            // 1. references can not be rebind -> refToSecond = ref numbers[0]
            // 2. reference persist even if array has changed its size
            
            Array.Resize(ref numbers, 1);
            Console.WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            refToSecond = 321;
            Console.WriteLine($"second = {refToSecond}, array size is {numbers.Length}");

            int[] moreNumbers = {10, 20, 30};
            //using function that returns reference
            ref int refToThirty = ref Find(moreNumbers, 30);
            refToThirty = 1000;
            
            // using Min function and getting ref to minimum value
            int a = 1, b = 2;
            ref int min = ref Min(ref a, ref b);
        }
        
        // getting reference using function
        static ref int Find(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                    return ref numbers[i];
            }

            throw new ArgumentException("meh");
        }

        static ref int Min(ref int x, ref int y)
        {
            if (x < y) return ref x;
            return ref y;
        }
    }
}
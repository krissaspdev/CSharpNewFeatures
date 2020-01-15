using System;

namespace NewFeatures._7_0
{
    public class DemoThrowExpression
    {
        public string Name { get; set; }

        public DemoThrowExpression(string name)
        {
            //null-coalescing exception
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int GetValue(int n)
        {
            // exception with ternary operator
            return n > 0 ? n + 1 : throw new Exception();
        }
        
    }
    
    public class ThrowExpression
    {
        static void Run()
        {
            int v = -1;
            try
            {
                var demo = new DemoThrowExpression("");
                v = demo.GetValue(-1); // if exception throws value is not assigned (v is still -1)
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(v);
            }
            
        }
    }
}
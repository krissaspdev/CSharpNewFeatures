using System;
using System.Linq;

namespace NewFeatures._7_1
{
    public class InferTupleNames
    {
        public static void Run()
        {
            var me = (name: "Kris", age: 30);
            var alsoMe = (age: me.name, name: me.name); // system knows the names of tuple elements
                                                        // even if they are not explicitly defined
                                                        
            Console.WriteLine(alsoMe.age);

            string[] months = {"March", "April", "May"};
            var result = months.Select(m => (
                m.Length, //we do not specify the name explicitly, but system takes this from property
                FirstChar: m[0]
                )).Where(x => x.Length ==5);
            
            Console.WriteLine(string.Join(",", result));

            var now = DateTime.UtcNow;
            var u = (now.Hour, now.Minute);
            (u.Hour, u.Minute) = (11, 12); //typical deconstruction syntax
            //system infers names properly
        }
    }
}
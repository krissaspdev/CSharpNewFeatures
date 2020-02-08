namespace NewFeatures._7_2
{
    public class PositionalAndNamedArguments
    {
        static void doSomething(int foo, int bar)
        {
            
        }

        public static void Run()
        {
            doSomething(33, bar: 44); // it was before C# 7.2
            doSomething(foo: 33, 44); // in 7.2 named argument can exist before positional
            doSomething(bar: 44, foo: 33); // it's possible to change the order of arguments only if you specify names explicitly
        }
    }
}
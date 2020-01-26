namespace NewFeatures._7_2
{
    public class Base
    {
        private int a;
        
        protected internal int b; // 1) derived classes (any assembly)
                                  // 2) classes in the same assembly

        // new access modifier
        private protected int c; // 1) containing class
                                 // 2) derived classes (current assembly)
    }

    public class PrivateProtectedAccessModifier
    {
        
    }
}
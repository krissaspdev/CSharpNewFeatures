namespace NewFeatures._7_0
{
    public class LiteralImprovements
    {
        public static void Run()
        {
            //we can now use underscore to improve visibility
            //for thousand separator

            int a = 123_3_34;
            int b = 12_____34___5; // underscore will be removed

            long h = 0xAB_AB4_AB;
            var bin = 1010_1100_1111;
        }
    }
}
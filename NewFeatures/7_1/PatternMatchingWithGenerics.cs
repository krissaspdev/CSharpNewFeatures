namespace NewFeatures._7_1
{
    public class Animal
    {
    }

    public class Pig: Animal
    {
    }

    public class PatternMatchingWithGenerics
    {
        public static void Cook<T>(T animal)
            where T : Animal
        {
            if (animal is Pig pig) // we don't have to cast animal to object
            {
                
            }

            switch (animal) // switch also works without casting
            {
                case Pig pork:
                    break;
            }
        }
    }
}
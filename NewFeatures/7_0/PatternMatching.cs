namespace NewFeatures._7_0
{
    public class Shape
    {
        
    }

    public class Rectangle: Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Circle: Shape
    {
        
    }

    public class PatternMatching
    {
        public static void DisplayShape(Shape shape)
        {
            // checking type and declaring variable in one if statement
            if (shape is Rectangle r)
            {
                
            }
            
            //new switch statement
            

            switch (shape)
            {
                case Circle c:
                    break;
                
                //extra condition in switch statement
                case  Rectangle sq when (sq.Width == sq.Height):
                    break;
            }
        }

        public static void Run()
        {
            
        }
    }
}
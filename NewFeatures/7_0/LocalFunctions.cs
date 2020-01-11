using System;

namespace NewFeatures._7_0
{
    public class LocalFunctions
    {
        
    }

    //old fashion declaring local function
    public class EquationSolverOldFashion
    {
        public static Tuple<double, double> SolveQuadratic(double a, double b, double c)
        {
            //b*b - 4 * a * c
            var CalculateDiscriminant = new Func<double, double, double, double>(
                (aa, bb, cc) => bb * bb - 4 * aa * cc);

            var disc = CalculateDiscriminant(a, b, c);
            var rootDisc = Math.Sqrt(disc);

            return Tuple.Create(
                (-b - rootDisc) / (2 * a),
                (-b + rootDisc) / (2 * a)
            );
        }
    }
    
    public class EquationSolverNewFashion
    {
        public static Tuple<double, double> SolveQuadratic(double a, double b, double c)
        {
            //b*b - 4 * a * c
            
            // local function 1
            // double CalculateDiscriminant(double aa, double bb, double cc)
            // {
            //     return bb * bb - 4 * aa * cc;
            // }
            
            //local function 2
            // capturing parameters from outer method
            double CalculateDiscriminant() => b * b - 4 * a * c;

            var disc = CalculateDiscriminant();
            var rootDisc = Math.Sqrt(disc);

            return Tuple.Create(
                (-b - rootDisc) / (2 * a),
                (-b + rootDisc) / (2 * a)
            );
        }
    }
}
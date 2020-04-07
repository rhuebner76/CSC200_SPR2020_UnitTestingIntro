using System;

namespace CSC200_SPR2020_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Manually calculate the square root of a number
        /// </summary>
        /// <param name="value">Number to find square root of</param>
        /// <returns>Square root of number</returns>
        public static double SquareRoot(double value)
        {
            if (value < 0.0)
                throw new ArgumentOutOfRangeException("value");

            if (value == 0)
                return 0;

            double root = value / 3;
            for (int i = 0; i < 32; i++)
            {
                // calculate the root of value
                root = (root + value / root) / 2;
            }

            return root;
        }
    }

    
}

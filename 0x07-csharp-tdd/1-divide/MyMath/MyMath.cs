using System;

namespace MyMath
{
    /// <summary>
    /// Basic math operation
    /// </summary>
    public class Matrix
    {
        /// <summary>
        ///  divides all elements of a matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
using System;

namespace MyMath
{
    /// <summary>
    /// Basic math operation
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// checks the max int in a list of int
        /// </summary>
        /// <param name="nums">lis being passed</param>
        /// <returns>max integer in a list of integers</returns>
        public static int Max(List<int> nums)
       {
            int num = 0;
            if (nums.Count != 0)
            {
                nums.Sort();
                num = nums[nums.Count - 1];
            }
            return (num);
        }
    }
}
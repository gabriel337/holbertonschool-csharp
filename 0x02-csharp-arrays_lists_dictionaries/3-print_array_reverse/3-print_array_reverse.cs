using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
        int[] reverse = Enumerable.Reverse(array).ToArray();
        Console.WriteLine(String.Join(',', reverse));
        }
    }        
}
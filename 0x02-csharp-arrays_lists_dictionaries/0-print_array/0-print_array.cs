using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            System.Environment.Exit(0);
        }
        int[] array = new int[size];
        int x;

        for (x = 0; x < size; x++)
        {
            array[x] = x;
            Console.Write(array[x] + " ");
        }
        Console.WriteLine();
        return array;
    }
} 
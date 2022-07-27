using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
        }
        List<int> list = new List<int>();
        int x = 0;

        if (size > 0)
        {
            for (x = 0; x < size; x++)
            {
                list.Add(x);
                Console.Write(list[x]);
                if (x != size - 1)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
        return list;
    }
} 
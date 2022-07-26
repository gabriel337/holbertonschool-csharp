using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 98; num++)
        {
            Console.Write(string.Format("{0:00}, ", num));
            
        }
        Console.Write("99\n");
    }
}
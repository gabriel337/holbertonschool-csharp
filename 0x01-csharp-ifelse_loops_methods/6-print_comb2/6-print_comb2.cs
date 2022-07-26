using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 7; i++)  
        {
            for(int j = 0; j <= 9; j++)  
            {
                if (i < j && i != j)
                {
                    Console.Write("{0}{1}, ",i,j);
                }
            }
        }
        Console.WriteLine("89");
    }
}
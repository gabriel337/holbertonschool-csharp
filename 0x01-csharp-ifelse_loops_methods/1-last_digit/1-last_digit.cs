﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastNumber = Math.Abs(number % 10);
        if (lastNumber > 5)
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is greater than 5", number, lastNumber);
        }
        else if (lastNumber < 6 && lastNumber != 0)
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is less than 6 and not 0",number, lastNumber);
        }
        else if (lastNumber == 0)
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is 0", number, lastNumber);
        }
    
    }
}
using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastNumber = number % 10;
        Console.Write("{0}", Math.Abs(lastNumber));
        return Math.Abs(lastNumber);
    }
}
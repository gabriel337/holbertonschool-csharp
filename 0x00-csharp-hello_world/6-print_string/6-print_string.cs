using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string repeatedString = string.Concat(Enumerable.Repeat(str,3));
        Console.WriteLine(repeatedString);
        string halfString = str.Substring(0,9);
        Console.WriteLine(halfString);
        }
}
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet == 'q' || alphabet == 'e')
                {
                    continue;
                }
                else
                {
                    Console.Write(alphabet);
                }
            }

    }
}
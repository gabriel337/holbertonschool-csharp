﻿using System;
using System.Collections.Generic;

class List
{    
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        
        for (int x = 0; x < n; x++)
        {
            try
            {
                Console.WriteLine(myList[x]);
                count++;
            }
            catch (ArgumentOutOfRangeException)
            {
                break;
            }
        }
        return (count);
    }
}

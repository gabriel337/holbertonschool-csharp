using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return (0);
        }
        LinkedList<int>.Enumerator num = myLList.GetEnumerator();
        while (num.MoveNext())
        {
            int res = num.Current;
            return res;
            
        }
        return (0);
    }
}
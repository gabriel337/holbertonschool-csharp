using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return (myList);
        }
        List<int> new_list = new List<int>();
        for (int i = 0; i < myList.Count; i++)
        {
            if(myList[i] == index)
            {
                myList.Remove(myList[index]);
            }
            else
            {
                new_list.Add(i);
        
            }
        }
        return new_list;
    }
}
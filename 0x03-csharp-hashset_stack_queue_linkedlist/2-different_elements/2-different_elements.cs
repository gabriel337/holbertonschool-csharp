using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var differences1 = list1.Except(list2);
        var differences2 = list2.Except(list1);
        List<int> new_list = new List<int>(); 
        foreach (var dif in differences1)
        {
            new_list.Add(dif);
        }

        foreach (var dif in differences2)
        {
            new_list.Add(dif);
        }
        new_list.Sort();
        return new_list;
    }
}
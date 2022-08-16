using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// 
/// </summary>
public class Obj
{
    /// <summary>
    ///  prints the names of the available properties and methods of an object
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        TypeInfo typeObj = myObj.GetType().GetTypeInfo();

        Console.WriteLine(typeObj.Name + " Properties:");
        foreach (PropertyInfo p in typeObj.GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine(typeObj.Name + " Methods:");
        foreach (MethodInfo m in typeObj.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
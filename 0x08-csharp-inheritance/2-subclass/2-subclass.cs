using System;
using System.Collections.Generic;

/// <summary>
/// Public class Obj
/// </summary>
public class Obj
{
    /// <summary>
    ///  returns True if the object is an instance of a class that inherits from the specified class, otherwise return False
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return (true);
        return (false);
    }
}
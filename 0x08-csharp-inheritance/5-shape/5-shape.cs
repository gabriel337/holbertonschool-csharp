using System;
using System.Collections.Generic;

/// <summary>
/// class with exception
/// </summary>
public class Shape
{
    /// <summary>
    /// Area class without Area implemented
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

}

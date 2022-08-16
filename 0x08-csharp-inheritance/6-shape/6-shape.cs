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

/// <summary>
/// Rectangle class, inherits from Shape
/// </summary>
public class Rectangle: Shape
{
    private int width, height;

/// <summary>
/// Width
/// </summary>
/// <value> width being passed</value>
    public int Width
    {
        get {return width;}
        
        set {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be greater than or equal to 0");
                }
                else
                {
                    width = value;
                }
            }
        
    }        

/// <summary>
/// Height
/// </summary>
/// <value>height being passed</value>
    public int Height
    {
        get {return height;}

        set {
                if (value < 0)
                    {
                        throw new ArgumentException("Height must be greater than or equal to 0");
                    }
                else
                {
                    height = value;
                }
            }
    }   
}

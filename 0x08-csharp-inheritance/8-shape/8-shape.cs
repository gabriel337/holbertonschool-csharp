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

/// <summary>
/// returns area
/// </summary>
/// <returns></returns>
    public override int Area()
    {
        return width * height;
    }

/// <summary>
/// returns width and heigh in string
/// </summary>
/// <returns></returns>
    public override string ToString()
    {
      return $"[Rectangle] {width} / {height}";   
    }
}

/// <summary>
/// Square class that inherits from Rectangle
/// </summary>
public class Square: Rectangle
{
    private int size;

/// <summary>
/// sets and gets size of square
/// </summary>
/// <value></value>
    public int Size
    {
        get {return size;}

        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
            }
        }

    }
}
using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        var top_item = aStack.Peek();

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }

        foreach (var item in aStack)
        {
            count++;
        }

        foreach (var item in aStack)
        {
            if (item == search)
            {
                var result = aStack.Peek();
            }
        }

        if (aStack.Contains(search))
        {
            string x;
            do
            {
                x = aStack.Pop();
            } while (x != search);
        }
        aStack.Push(newItem);

        Console.WriteLine("Number of items: {0}", count);
        Console.WriteLine("Top item: {0}", top_item);
        Console.WriteLine("Stack contains \"{0}\": True", search);
        return aStack;
    }
}
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
       
    }
}

public class Valid_Parentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch); // Открывающая скобка добавляется в стек
            }
            else
            {
                // Если стек пуст или скобки не соответствуют
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), ch))
                {
                    return false;
                }
            }
        }

        // Если стек пустой, то все скобки сбалансированы
        return stack.Count == 0;
    }

    private bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}

using System;
using System.IO;
using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            string parse = sr.ReadLine();
            if (parse == ".")
                break;

            Stack<char> stack = new Stack<char>();
            bool invalid = false;

            foreach (char c in parse)
            {
                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']')
                {
                    if (stack.Count != 0 && IsMatching(stack.Pop(), c)) continue;
                    invalid = true;
                    break;
                }
            }

            sw.WriteLine(!invalid && stack.Count == 0 ? "yes" : "no");
        }
    }

    static bool IsMatching(char open, char close)
    {
        return (open == '(' && close == ')') || (open == '[' && close == ']');
    }
}
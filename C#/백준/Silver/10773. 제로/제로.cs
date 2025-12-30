using System;
using System.IO;
using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());

        var s = new Stack<int>();
        
        for (int i = 0; i < n; i++)
        {
            int inp = int.Parse(sr.ReadLine());

            if (inp == 0)
            {
                s.Pop();
                continue;
            }
            
            s.Push(inp);
        }

        int sum = 0;
        foreach (var i in s) { sum += i; }
        sw.Write(sum);
        
        sr.Close();
        sw.Close();
    }
}
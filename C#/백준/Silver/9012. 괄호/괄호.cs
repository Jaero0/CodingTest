using System;
using System.IO;
using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string s = sr.ReadLine();

            int count = 0;
            bool invalid = false;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;
                    if (count < 0)
                    {
                        invalid = true;
                    }
                }
            }
            
            sw.WriteLine(invalid == false && count == 0 ? "YES" : "NO");
        }
    }
}
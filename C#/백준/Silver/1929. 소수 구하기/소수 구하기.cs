using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers;

public class MainClass
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int f = int.Parse(inputs[0]);
        int s = int.Parse(inputs[1]);

        StringBuilder sb = new StringBuilder();

        bool[] arr = new bool[s + 1];
        arr[0] = true;
        arr[1] = true;

        int sqrt = (int)Math.Sqrt(s);

        for (int i = 2; i <= sqrt; i++)
        {
            if (arr[i] == false) {
                for (int j = i * i; j <= s; j+=i)
                {
                    arr[j] = true;
                }
            }
        }
        
        for (int i = f; i <= s; i++)
        {
            if (arr[i] == false)
            {
                sb.Append(i + "\n");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
using System;

namespace Programmers;

public class MainClass
{
    static void Main(string[] args)
    {
        string[] sp = Console.ReadLine().Split(' ');
        int f = int.Parse(sp[0]);
        int s = int.Parse(sp[1]);

        int gcd = GetGCD(f, s);
        int l = f * s / gcd;

        Console.WriteLine(gcd);
        Console.WriteLine(l);
    }

    private static int GetGCD(int f, int s)
    {
        if (f % s == 0)
        {
            return s;
        }

        return GetGCD(s, f % s);
    }
}
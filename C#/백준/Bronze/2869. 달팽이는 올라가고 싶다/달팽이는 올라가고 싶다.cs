using System;

namespace Programmers;

public class MainClass
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');

        int climb = int.Parse(inputs[0]);
        int fall = int.Parse(inputs[1]);
        int max = int.Parse(inputs[2]);

        Console.WriteLine((max - fall) % (climb - fall) == 0 ? (max - fall) / (climb - fall) : (max - fall) / (climb - fall) + 1 );

        //n = days
        //-fall * (n - 1) + climb  * n >= max 
        //-fall * n + fall + climb * n >= max
        //-fall * n + climb * n >= max - fall
        //(climb-fall) * n >= max - fall
        //n = (max - fall) / (climb - fall)
    }
}
namespace Testt;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int ind = 0;
        int res = 0;
        for (int i = 0; i < 3; i++)
        {
            if (int.TryParse(sr.ReadLine(), out var result))
            {
                ind = i;
                res = result;
            }
        }

        res += ind == 0 ? 3 : ind == 1 ? 2 : 1;

        if (res % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (res % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (res % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(res);
        }

        sw.Close();
        sr.Close();
    }
}
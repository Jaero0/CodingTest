using System.Collections;

namespace Testt;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        /***
         * 1
         * 2 - 2
         * 3 - 2 * 3
         * 4 - 2^3 * 3
         * 5 - 2^3 * 3 * 5
         * 6 - 2^4 * 3 * 5
         * 7 - 2^4 * 3 * 5 * 7
         * 8 - 2^7 * 3 * 5 * 7
         * 9 - 2^7 * 3^3 * 5 * 7
         * 10 - 2^8 * 3^3 * 5^2 * 7
         * 11 - 2^8...5^2
         * 15 - 2^x * 5^3
         * ...
         * 20 - 2^x * 5^4
         * ...
         * 25 - 2^x * 5^6
         */

        int N = int.Parse(sr.ReadLine());

        int ans = N / 5;
        if (N >= 125)
        {
            ans +=  N / 125;
        }
        if (N >= 25)
        {
            ans += N / 25;
        }
        
        sw.WriteLine(ans);
        
        sw.Close();
        sr.Close();
    }
}
using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] nm = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        int[] inp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        int[] dp = new int[nm[0]];
        dp[0] = inp[0];
        for (int i = 1; i < nm[0]; i++)
        {
            dp[i] = dp[i - 1] + inp[i];
        }

        //5 9 12 14 15
        //5 4 3  2  1
        for (int i = 0; i < nm[1]; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int t1 = dp[t[1] - 1];
            int t2 = t[0] - 2 < 0 ? 0 : dp[t[0] - 2];
            
            sw.WriteLine(t1-t2);
        }
    }
}
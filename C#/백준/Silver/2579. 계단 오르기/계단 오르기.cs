using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        int[] stair = new int[N];
        int[] dp = new int[N];

        for (int i = 0; i < N; i++)
        {
            stair[i] = int.Parse(sr.ReadLine());
        }

        dp[0] = stair[0];
        if (N > 1)
        {
            dp[1] = dp[0] + stair[1];
        }

        if (N > 2)
        {
            dp[2] = stair[2] + Math.Max(stair[0], stair[1]);
        }
        
        //10 20 15 25 10
        //10 30 35 55 65
        for (int i = 3; i < N; i++)
        {
            dp[i] = dp[i] = Math.Max(stair[i] + stair[i - 1] + dp[i - 3], stair[i] + dp[i - 2]);
        }
        
        sw.WriteLine(dp[N - 1]);
    }
}
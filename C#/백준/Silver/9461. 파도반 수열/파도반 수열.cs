using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        long[] arr = new long[101];
        arr[1] = 1;
        arr[2] = 1;
        for (int i = 3; i < 101; i++)
        {
            arr[i] = arr[i - 2] + arr[i - 3];
        }

        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());
            sw.WriteLine(arr[t]);
        }
    }
}
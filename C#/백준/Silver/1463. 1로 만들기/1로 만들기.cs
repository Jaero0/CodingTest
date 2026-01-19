using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        int[] arr = new int[N + 2];
        arr[1] = 0;

        for (int i = 2; i <= N; i++)
        {
            arr[i] = arr[i - 1] + 1;

            if (i % 2 == 0)
            {
                arr[i] = Math.Min(arr[i], arr[i / 2] + 1);
            }

            if (i % 3 == 0)
            {
                arr[i] = Math.Min(arr[i], arr[i / 3] + 1);
            }
        }
        
        sw.WriteLine(arr[N]);
    }
}
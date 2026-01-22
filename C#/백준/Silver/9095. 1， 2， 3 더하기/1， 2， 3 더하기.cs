using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        /*
         * 1 1->1
         * 2 1+1, 2->2
         * 3 1+1+1, 1+2, 2+1, 3->4
         * 4 1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 3+1, 2+2, 1+3->7
         * 5 13
         * 6 24
         */
        int[] arr = new int[12];
        arr[0] = 0;
        arr[1] = 1;
        arr[2] = 2;
        arr[3] = 4;

        for (int i = 4; i < 12; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
        }

        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());
            sw.WriteLine(arr[t]);
        }
    }
}
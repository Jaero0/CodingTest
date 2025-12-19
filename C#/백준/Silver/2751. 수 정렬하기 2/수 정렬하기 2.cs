using System.Collections;

namespace Testt;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());

            arr[i] = t;
        }
        
        Array.Sort(arr);
        
        Array.ForEach(arr, sw.WriteLine);
        
        sw.Close();
        sr.Close();
    }
}
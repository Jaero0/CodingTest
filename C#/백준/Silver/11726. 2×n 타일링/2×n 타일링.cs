using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        
        //(1) 1 2 3 5 8 13 21 34 55 
        int[] arr = new int[N + 1];
        arr[0] = 1;
        arr[1] = 1;
        for (int i = 2; i < N + 1; i++)
        {
            arr[i] = (arr[i - 1] + arr[i - 2]) % 10007;
        }
        
        sw.WriteLine(arr[N]);
    }
}
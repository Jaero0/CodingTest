using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        var l = new List<int>();
        string[] s = sr.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(s[i]);
            
            l.Add(t);
        }

        l.Sort();

        var arr = new int[N];
        arr[0] = l[0];
        for (int i = 1; i < N; i++)
        {
            arr[i] = arr[i-1] + l[i];
        }

        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += arr[i];
        }
        sw.Write(sum);
    }
}
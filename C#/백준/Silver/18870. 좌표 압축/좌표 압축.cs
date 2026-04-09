using System.Collections;

public class Solution
{
    private const int bufSize = 131072;
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput(), bufSize));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput(), bufSize));
    
    public static void Main(string[] args)
    {
        var n = int.Parse(sr.ReadLine());

        var arr = new int[n];
        var t = sr.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(t[i]);
        }

        var sorted = arr.ToArray();
        Array.Sort(sorted);
        var dict = new Dictionary<int, int>();

        int count = 0;
        foreach (int i in sorted)
        {
            if (dict.TryAdd(i, count))
            {
                count++;
            }
        }

        foreach (int i in arr)
        {
            sw.Write(dict[i] + " ");
        }

        sr.Close();
        sw.Close();
    }
}
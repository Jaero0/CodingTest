using System.Collections;

public class Solution
{
    private const int bufSize = 131072;
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput(), bufSize));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput(), bufSize));
    
    public static void Main(string[] args)
    {
        int n = int.Parse(sr.ReadLine());
        int[] arr = new int[n];

        var t = sr.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(t[i]);
        }

        
        int left = 0;
        int count = 0;
        
        var dict = new Dictionary<int, int>();

        for (int right = 0; right < n; right++)
        {
            if (!dict.TryAdd(arr[right], 1))
            {
                dict[arr[right]]++;
            }

            while (dict.Count > 2)
            {
                dict[arr[left]]--;

                if (dict[arr[left]] == 0)
                {
                    dict.Remove(arr[left]);
                }

                left++;
            }
            
            count = Math.Max(count, right - left + 1);
        }

        sw.Write(count);
        
        sr.Close();
        sw.Close();
    }
}
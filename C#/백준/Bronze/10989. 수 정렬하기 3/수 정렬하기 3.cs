namespace Testt;

public class Solution {
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        SortedDictionary<short, int> d = new SortedDictionary<short, int>();
        int l = int.Parse(sr.ReadLine());

        for (int i = 0; i < l; i++)
        {
            short t = short.Parse(sr.ReadLine());

            if (!d.ContainsKey(t))
            {
                d.Add(t, 1);
                continue;
            }

            d[t]++;
        }

        foreach (var kvp in d)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                sw.WriteLine(kvp.Key);
            }
        }
        
        sw.Close();
        sr.Close();
    }
}
using System.Collections;

public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        var n = int.Parse(sr.ReadLine());

        var set = new SortedSet<int>();
        var list = new List<int>();
        var t = sr.ReadLine().Split(' ');

        foreach (string s in t)
        {
            int st = int.Parse(s);

            set.Add(st);
            list.Add(st);
        }
        
        var dict = new Dictionary<int, int>();

        int count = 0;
        foreach (int i in set)
        {
            if (dict.TryAdd(i, count))
            {
                count++;
            }
            
        }

        foreach (int i in list)
        {
            sw.Write(dict[i] + " ");
        }

        sr.Close();
        sw.Close();
    }
}
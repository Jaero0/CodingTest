using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        var dict = new Dictionary<string, int>();

        for (int i = 0; i < NM[0]; i++)
        {
            string t = sr.ReadLine();
            
            dict.Add(t, 1);
        }

        var l = new List<string>();

        for (int i = 0; i < NM[1]; i++)
        {
            string t = sr.ReadLine();

            if (dict.ContainsKey(t))
            {
                l.Add(t);
            }
        }

        sw.WriteLine(l.Count);

        l.Sort();
        l.ForEach(s=>sw.WriteLine(s));
    }
}
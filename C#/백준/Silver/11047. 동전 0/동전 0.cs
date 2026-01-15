using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        var l = new List<int>();
        for (int i = 0; i < NM[0]; i++)
        {
            int t = int.Parse(sr.ReadLine());

            l.Add(t);
        }

        int count = 0;
        for (int i = l.Count - 1; i >= 0; i--)
        {
            if (NM[1] / l[i] > 0)
            {
                while (NM[1] - l[i] >= 0)
                {
                    NM[1] -= l[i];
                    count++;
                }
            }
        }
        
        sw.WriteLine(count);
    }
}
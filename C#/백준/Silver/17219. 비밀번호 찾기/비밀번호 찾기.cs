using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        var dict = new Dictionary<string, string>();
        for (int i = 0; i < NM[0]; i++)
        {
            string[] t = sr.ReadLine().Split(' ');
            dict.Add(t[0], t[1]);
        }

        for (int i = 0; i < NM[1]; i++)
        {
            string t = sr.ReadLine();
            
            sw.WriteLine(dict[t]);
        }
    }
}
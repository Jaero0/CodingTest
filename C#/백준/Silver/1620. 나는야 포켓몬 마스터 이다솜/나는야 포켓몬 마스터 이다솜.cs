using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        string[] name = new string[NM[0]];
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < NM[0]; i++)
        {
            string t = sr.ReadLine();

            name[i] = t;
            dict.Add(t, i);
        }

        for (int i = 0; i < NM[1]; i++)
        {
            string t = sr.ReadLine();
            int parse = 0;

            if (int.TryParse(t, out parse))
            {
                sw.WriteLine(name[parse - 1]);
            }
            else
            {
                sw.WriteLine(dict[t] + 1);
            }
        }
    }
}
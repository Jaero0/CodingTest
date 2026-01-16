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

        int sum = 0;
        int total = 0;
        for (int i = 0; i < N; i++)
        {
            sum += l[i];
            total += sum;
        }
        sw.Write(total);
    }
}
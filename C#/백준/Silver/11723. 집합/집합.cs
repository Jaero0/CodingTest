using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        int[] ar = new int[21];

        for (int i = 0; i < N; i++)
        {
            string[] inp = sr.ReadLine().Split(' ');
            
            int t = 0;
            if (inp.Length > 1)
            {
                t = int.Parse(inp[1]);
            }

            if (inp[0] == "add")
            {
                ar[t]++;
            }
            else if (inp[0] == "remove")
            {
                if (ar[t] > 0)
                {
                    ar[t]--;
                }
            }
            else if (inp[0] == "check")
            {
                sw.WriteLine(ar[t] > 0 ? 1 : 0);
            }
            else if (inp[0] == "toggle")
            {
                if (ar[t] > 0)
                {
                    ar[t]--;
                }
                else
                {
                    ar[t]++;
                }
            }
            else if (inp[0] == "all")
            {
                for (int j = 0; j < 21; j++)
                {
                    ar[j] = 1;
                }
            }
            else
            {
                for (int j = 0; j < 21; j++)
                {
                    ar[j] = 0;
                }
            }
        }
    }
}
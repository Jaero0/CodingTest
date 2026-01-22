using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int c = int.Parse(sr.ReadLine());

            var nameCategory = new Dictionary<string, List<string>>();

            //init dict
            for (int j = 0; j < c; j++)
            {
                string[] s = sr.ReadLine().Split(' ');

                if (nameCategory.TryGetValue(s[1], out var v))
                {
                    v.Add(s[0]);
                }
                else
                {
                    nameCategory.Add(s[1], new List<string>(){s[0]});
                }
            }

            //calc
            int count = nameCategory.Count;
            int sum = 1;
            foreach (var kvp in nameCategory)
            {
                sum *= (kvp.Value.Count + 1);
            }
            
            sw.WriteLine(sum-1);
        }
    }
}
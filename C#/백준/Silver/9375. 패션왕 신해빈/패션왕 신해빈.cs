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

            var nameCategory = new Dictionary<string, int>();

            //init dict
            for (int j = 0; j < c; j++)
            {
                string[] s = sr.ReadLine().Split(' ');

                if (nameCategory.TryGetValue(s[1], out int value))
                {
                    nameCategory[s[1]] = value + 1;
                }
                else
                {
                    nameCategory.Add(s[1], 1);
                }
            }

            //calc
            int sum = 1;
            foreach (var kvp in nameCategory)
            {
                sum *= (kvp.Value + 1);
            }
            
            sw.WriteLine(sum-1);
        }
    }
}
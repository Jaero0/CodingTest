using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        var dict = new Dictionary<int, List<int>>();
        bool[] visited = new bool[N + 1];

        int N2 = int.Parse(sr.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            dict.Add(i+1, new List<int>());            
        }

        for (int i = 0; i < N2; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            dict[t[0]].Add(t[1]);
            dict[t[1]].Add(t[0]);
        }

        var q = new Queue<int>();
        q.Enqueue(1);

        int count = -1;
        while (q.Count != 0)
        {
            int key = q.Dequeue();
            var l = dict[key];

            if (visited[key] == true)
            {
                continue;
            }

            visited[key] = true;
            count++;

            foreach (var t in l)
            {
                if (visited[t] == true)
                {
                    continue;
                }
                
                q.Enqueue(t);
            }
        }
        
        sw.WriteLine(count);
    }
}
using System.Collections;

public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        var input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        List<int>[] dict2 = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            dict2[i] = new List<int>();
        }

        //1. init
        for (int i = 0; i < m; i++)
        {
            var input2 = sr.ReadLine().Split();
            int a = int.Parse(input2[0]);
            int b = int.Parse(input2[1]);

            dict2[a].Add(b);
            dict2[b].Add(a);
        }

        int count = 0;
        var q = new Queue<int>();
        bool[] visited = new bool[n + 1];

        for (int i = 1; i <= n; i++)
        {
            if (visited[i] == true) continue;
            
            visited[i] = true;
            count++;
            q.Enqueue(i);

            while (q.Count > 0)
            {
                int key = q.Dequeue();
                var list = dict2[key];

                foreach (var j in list)
                {
                    if (visited[j]) continue;

                    visited[j] = true;
                    q.Enqueue(j);
                }
            }
        }
        
        sw.WriteLine(count);

        sr.Close();
        sw.Close();
    }
}
using System.Collections;

public class Solution
{
    private const int bufSize = 131072;
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput(), bufSize));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput(), bufSize));
    
    public struct Pair
    {
        public int start = 0;
        public int count = 0;

        public Pair(int s, int c)
        {
            start = s;
            count = c;
        }
    }
    
    public static void Main(string[] args)
    {
        string[] nm = sr.ReadLine().Split(' ');
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        List<int>[] list = new List<int>[n + 1];
        for (int i = 1; i < n + 1; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            string[] t = sr.ReadLine().Split(' ');
            int start = int.Parse(t[0]);
            int end = int.Parse(t[1]);
            
            list[start].Add(end);
            list[end].Add(start);
        }
        
        //bfs
        
        var sums = new int[n + 1];
        for (int i = 1; i < n + 1; i++)
        {
            var q = new Queue<Pair>();
            var visited = new bool[n + 1];
            
            q.Enqueue(new Pair(i, 0));
            visited[i] = true;

            int sum = 0;

            while (q.Count > 0)
            {
                var pair = q.Dequeue();
                int start = pair.start;
                int count = pair.count + 1;

                foreach (int k in list[start])
                {
                    if (visited[k])
                    {
                        continue;
                    }
                    
                    sum += count;
                    visited[k] = true;
                    q.Enqueue(new Pair(k, count));
                }
            }
            
            sums[i] = sum;
        }

        var p = new Pair(n + 1, int.MaxValue);
        for (int i = 1; i < n + 1; i++)
        {
            int sum = sums[i];

            if (p.count <= sum) continue;
            p.start = i;
            p.count = sum;
        }
        
        sw.WriteLine(p.start);
        
        sr.Close();
        sw.Close();
    }
}
public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    public static void DFS(List<int>[] g, int startNode, bool[] visited)
    {
        List<int> graph = g[startNode];
        visited[startNode] = true;
        sw.Write(startNode + " ");

        foreach (var i in graph)
        {
            if (visited[i] == true)
            {
                continue;
            }

            DFS(g, i, visited);
        }
    }

    public static void BFS(List<int>[] g, int startNode, bool[] visited)
    {
        Queue<int> haveToVisit = new Queue<int>();
        haveToVisit.Enqueue(startNode);
        visited[startNode] = true;

        while (haveToVisit.Count != 0)
        {
            int node = haveToVisit.Dequeue();
            sw.Write(node + " ");

            foreach (var i in g[node])
            {
                if (visited[i] == true)
                {
                    continue;
                }

                haveToVisit.Enqueue(i);
                visited[i] = true;
            }
        }
    }
    
    public static void Main(string[] args)
    {
        

        int[] NMV = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        List<int>[] g = new List<int>[NMV[0] + 1];

        for (int i = 0; i < g.Length; i++)
        {
            g[i] = new List<int>();
        }
        
        bool[] visited = new bool[g.Length];
        
        for (int i = 0; i < NMV[1]; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                g[t[0]].Add(t[1]);
                g[t[1]].Add(t[0]);
            
        }
        
        Array.ForEach(g, l =>
        {
            if (l != null) { l.Sort(); }
        });

        DFS(g, NMV[2], visited);
        sw.WriteLine();
        visited = new bool[g.Length];
        BFS(g, NMV[2], visited);
        
        sr.Close();
        sw.Close();
    }
}
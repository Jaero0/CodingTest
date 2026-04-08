using System.Collections;

public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        List<int>[] dict2 = new List<int>[NM[0] + 1];

        for (int i = 1; i <= NM[0]; i++)
        {
            dict2[i] = new List<int>();
        }

        //1. init
        for (int i = 0; i < NM[1]; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            dict2[t[0]].Add(t[1]);

            dict2[t[1]].Add(t[0]);
        }

        int count = 0;
        var q = new Queue<int>();
        bool[] visited = new bool[NM[0] + 1];

        for (int i = 1; i <= NM[0]; i++)
        {
            if (visited[i] == true) continue;
            
            visited[i] = true;
            count++;
            q.Enqueue(i);

            while (q.Count > 0)
            {
                int key = q.Dequeue();
                var list = dict2[key];

                foreach (int j in list)
                {
                    if (visited[j] == true)
                    {
                        continue;
                    }
                    q.Enqueue(j);
                    visited[j] = true;
                }
            }
        }
        
        sw.WriteLine(count);

        sr.Close();
        sw.Close();
    }
}
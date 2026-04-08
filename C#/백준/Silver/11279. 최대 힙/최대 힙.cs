using System.Collections;

public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        int N = int.Parse(sr.ReadLine());

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((i1, i2) => i2 - i1));

        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());

            if (t == 0)
            {
                if (pq.TryDequeue(out int e, out int p))
                {
                    sw.WriteLine(e);
                }
                else
                {
                    sw.WriteLine(0);
                }
            }
            else
            {
                pq.Enqueue(t, t);
            }
        }

        sr.Close();
        sw.Close();
    }
}
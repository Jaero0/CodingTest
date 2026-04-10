using System.Collections;

public class Solution
{
    private const int bufSize = 131072;
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput(), bufSize));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput(), bufSize));

    private static int[] xMove = new int[] { -1, 1, 0, 0 };
    private static int[] yMove = new int[] { 0, 0, -1, 1 };
    
    public static void Main(string[] args)
    {
        var NM = sr.ReadLine().Split(' ');
        int n = int.Parse(NM[0]);
        int m = int.Parse(NM[1]);

        char[,] cam = new char[n, m];
        var q = new Queue<Tuple<int,int>>();
        
        for (int i = 0; i < n; i++)
        {
            var t = sr.ReadLine();
            for (int j = 0; j < m; j++)
            {
                cam[i, j] = t[j];

                if (t[j] == 'I')
                {
                   q.Enqueue(new Tuple<int, int>(i, j));
                }
            }
        }

        bool[,] visited = new bool[n, m];
        visited[q.Peek().Item1, q.Peek().Item2] = true;

        int count = 0;
        while (q.Count > 0)
        {
            var t = q.Dequeue();
            
            for (int i = 0; i < 4; i++)
            {
                int movX = t.Item2 + xMove[i];
                int movY = t.Item1 + yMove[i];

                if (movY < 0 || movY >= n || movX < 0 || movX >= m || 
                    cam[movY, movX] == 'X' || visited[movY, movX] == true)
                {
                    continue;
                }
                
                q.Enqueue(new Tuple<int, int>(movY, movX));
                if (cam[movY,movX] == 'P')
                {
                    count++;
                }
                visited[movY, movX] = true;
            }
        }
        
        sw.WriteLine(count == 0 ? "TT" : count);
        
        sr.Close();
        sw.Close();
    }
}
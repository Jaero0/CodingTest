using System.Collections;

public class Solution
{
    private const int bufSize = 131072;
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput(), bufSize));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput(), bufSize));

    public static void Main(string[] args)
    {
        string[] nm = sr.ReadLine().Split(' ');
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        
        int[] move = new int[] { -1, 1, 2 };

        //bfs
        var q = new Queue<Tuple<int, int>>();
        var visited = new HashSet<int>();

        q.Enqueue(new Tuple<int, int>(n, 0));
        visited.Add(n);

        int sum = 0;
        bool isBroken = false;

        while (q.Count > 0)
        {
            var pair = q.Dequeue();

            for (int i = 0; i < 3; i++)
            {
                int mov = i == 2 ? pair.Item1 * move[i] : pair.Item1 + move[i];
                
                if (visited.Contains(mov) || mov < 0 || mov > 100000)
                {
                    continue;
                }

                if (mov == m)
                {
                    sum = pair.Item2 + 1;
                    isBroken = true;
                    break;
                }

                visited.Add(mov);
                q.Enqueue(new Tuple<int, int>(mov, pair.Item2 + 1));
            }

            if (isBroken)
            {
                break;
            }
        }


        sw.WriteLine(sum);

        sr.Close();
        sw.Close();
    }
}